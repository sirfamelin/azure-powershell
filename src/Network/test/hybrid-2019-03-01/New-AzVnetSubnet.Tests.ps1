$TestRecordingFile = Join-Path $PSScriptRoot 'New-AzVnetSubnet.Recording.json'
. (Join-Path $PSScriptRoot '..\generated\runtime' 'HttpPipelineMocking.ps1')

Describe 'New-AzVnetSubnet' {
    It 'CreateExpanded1' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create1' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateViaIdentityExpanded1' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateViaIdentity1' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
