$TestRecordingFile = Join-Path $PSScriptRoot 'Update-AzDnsRecordSet.Recording.json'
. (Join-Path $PSScriptRoot '..\generated\runtime' 'HttpPipelineMocking.ps1')

Describe 'Update-AzDnsRecordSet' {
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
