$TestRecordingFile = Join-Path $PSScriptRoot 'Set-AzDnsRecordSet.Recording.json'
. (Join-Path $PSScriptRoot '..\generated\runtime' 'HttpPipelineMocking.ps1')

Describe 'Set-AzDnsRecordSet' {
    It 'UpdateSoa' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateA' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateAaaa' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateCaa' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateCname' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateMX' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateNS' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdatePtr' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateSrv' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateTxt' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
