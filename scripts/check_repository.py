#!/usr/bin/env python3
from pathlib import Path
import re
import sys

ROOT = Path(__file__).resolve().parents[1]
required = [
    ROOT / "csharp" / "perfect-number",
    ROOT / "csharp" / "power-calculator",
    ROOT / "csharp" / "multiplication-table",
    ROOT / "csharp" / "palindrome-checker",
    ROOT / "csharp" / "prime-or-composite",
    ROOT / "web" / "Home.html",
    ROOT / "web" / "index.html",
]
missing = [str(path.relative_to(ROOT)) for path in required if not path.exists()]
if missing:
    print("Missing required paths: " + ", ".join(missing), file=sys.stderr)
    sys.exit(1)

for path in ROOT.rglob("*"):
    if ".git" in path.parts:
        continue
    rel = path.relative_to(ROOT).as_posix()
    if any(part.startswith("._") or part in {"Backup", "_UpgradeReport_Files"} for part in path.parts) or path.name in {".DS_Store", "Thumbs.db"}:
        print(f"Metadata or backup file should not be staged: {rel}", file=sys.stderr)
        sys.exit(1)
    if path.suffix.lower() in {".suo", ".user", ".exe", ".dll", ".jpg", ".jpeg", ".png", ".gif", ".wmv"}:
        print(f"Forbidden generated/private artifact: {rel}", file=sys.stderr)
        sys.exit(1)

text_files = [p for p in ROOT.rglob("*") if p.is_file() and ".git" not in p.parts and p.suffix.lower() in {".cs", ".csproj", ".sln", ".resx", ".settings", ".config", ".html", ".md", ""}]
combined = "\n".join(p.read_text(encoding="utf-8", errors="ignore") for p in text_files)
markers = ["".join(["208", "234", "161"]), "/" + "Users" + "/", "/" + "home" + "/", "C:" + "\\" + "Users"]
if any(marker in combined for marker in markers) or re.search(r"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+", combined):
    print("Privacy or machine-path marker found in tracked text", file=sys.stderr)
    sys.exit(1)
for marker in ["System.Windows.Forms", "partial class Form1", "<html"]:
    if marker not in combined:
        print(f"Missing expected marker: {marker}", file=sys.stderr)
        sys.exit(1)
print("Repository static checks passed.")
