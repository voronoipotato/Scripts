[console]::Beep(400,300)
echo "Starting pomodoro, you have 25 minutes"
Start-Sleep -Seconds (25*60); [console]::Beep(500,300)
echo "Time to rest (10 minutes)"
Start-Sleep -Seconds (10*60); [console]::Beep(600,300)
echo "You're done resting!"