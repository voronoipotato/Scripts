param([Int32]$minutes=30)
[console]::Beep(400,300)
echo "Starting timer, you have $minutes minutes"
Start-Sleep -Seconds ($minutes*60); [console]::Beep(500,300)
