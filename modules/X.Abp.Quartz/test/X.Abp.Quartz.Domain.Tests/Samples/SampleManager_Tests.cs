﻿using System.Threading.Tasks;
using Xunit;

namespace X.Abp.Quartz.Samples;

public class SampleManager_Tests : QuartzDomainTestBase
{
    //private readonly SampleManager _sampleManager;

    public SampleManager_Tests()
    {
        //_sampleManager = GetRequiredService<SampleManager>();
    }

    [Fact]
    public Task Method1Async()
    {
        return Task.CompletedTask;
    }
}
