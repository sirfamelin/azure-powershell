$TestRecordingFile = Join-Path $PSScriptRoot 'Set-AzRouteTable.Recording.json'
. (Join-Path $PSScriptRoot '..\generated\runtime' 'HttpPipelineMocking.ps1')

Describe 'Set-AzRouteTable' {
    It 'UpdateExpanded1' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update1' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
