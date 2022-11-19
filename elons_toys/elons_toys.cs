using System;

class RemoteControlCar
{
    float battery = 100f;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return  $"Driven {(100 - battery)*20} meters";
    }

    public string BatteryDisplay()
    {
        if(battery <= 0)
            return "Battery empty";
        else
            return $"Battery at {battery}%";
    }

    public void Drive()
    {
        if(battery > 0)
            battery--;
    }
}