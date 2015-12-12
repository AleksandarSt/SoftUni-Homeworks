﻿using System;


public class PropertyChangedEventArgs:EventArgs
{
    private string propertyName;
    private string oldValue;
    private string newValue;

    public PropertyChangedEventArgs(string propertyName,string oldValue, string newValue)
    {
        this.PropertyName = propertyName;
        this.OldValue = oldValue;
        this.NewValue = newValue;
    }

    public string PropertyName { get; set; }

    public string OldValue { get; set; }

    public string NewValue { get; set; }
}
