﻿// -----------------------------------------------------------------------------
﻿//
﻿// Copyright Microsoft Corporation
﻿// Licensed under the Apache License, Version 2.0 (the "License");
﻿// you may not use this file except in compliance with the License.
﻿// You may obtain a copy of the License at
﻿// http://www.apache.org/licenses/LICENSE-2.0
﻿// Unless required by applicable law or agreed to in writing, software
﻿// distributed under the License is distributed on an "AS IS" BASIS,
﻿// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
﻿// See the License for the specific language governing permissions and
﻿// limitations under the License.
﻿// -----------------------------------------------------------------------------
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Batch.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Microsoft.Azure.Batch;
    
    
    public class PSCloudPool
    {
        
        internal Microsoft.Azure.Batch.CloudPool omObject;
        
        private IList<PSApplicationPackageReference> applicationPackageReferences;
        
        private PSAutoScaleRun autoScaleRun;
        
        private IList<PSCertificateReference> certificateReferences;
        
        private PSCloudServiceConfiguration cloudServiceConfiguration;
        
        private IList<PSMetadataItem> metadata;
        
        private PSResizeError resizeError;
        
        private PSStartTask startTask;
        
        private PSPoolStatistics statistics;
        
        private PSTaskSchedulingPolicy taskSchedulingPolicy;
        
        private PSVirtualMachineConfiguration virtualMachineConfiguration;
        
        internal PSCloudPool(Microsoft.Azure.Batch.CloudPool omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }
        
        public Microsoft.Azure.Batch.Common.AllocationState? AllocationState
        {
            get
            {
                return this.omObject.AllocationState;
            }
        }
        
        public System.DateTime? AllocationStateTransitionTime
        {
            get
            {
                return this.omObject.AllocationStateTransitionTime;
            }
        }
        
        public IList<PSApplicationPackageReference> ApplicationPackageReferences
        {
            get
            {
                if (((this.applicationPackageReferences == null) 
                            && (this.omObject.ApplicationPackageReferences != null)))
                {
                    List<PSApplicationPackageReference> list;
                    list = new List<PSApplicationPackageReference>();
                    IEnumerator<Microsoft.Azure.Batch.ApplicationPackageReference> enumerator;
                    enumerator = this.omObject.ApplicationPackageReferences.GetEnumerator();
                    for (
                    ; enumerator.MoveNext(); 
                    )
                    {
                        list.Add(new PSApplicationPackageReference(enumerator.Current));
                    }
                    this.applicationPackageReferences = list;
                }
                return this.applicationPackageReferences;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.ApplicationPackageReferences = null;
                }
                else
                {
                    this.omObject.ApplicationPackageReferences = new List<Microsoft.Azure.Batch.ApplicationPackageReference>();
                }
                this.applicationPackageReferences = value;
            }
        }
        
        public System.Boolean? AutoScaleEnabled
        {
            get
            {
                return this.omObject.AutoScaleEnabled;
            }
            set
            {
                this.omObject.AutoScaleEnabled = value;
            }
        }
        
        public System.TimeSpan? AutoScaleEvaluationInterval
        {
            get
            {
                return this.omObject.AutoScaleEvaluationInterval;
            }
            set
            {
                this.omObject.AutoScaleEvaluationInterval = value;
            }
        }
        
        public string AutoScaleFormula
        {
            get
            {
                return this.omObject.AutoScaleFormula;
            }
            set
            {
                this.omObject.AutoScaleFormula = value;
            }
        }
        
        public PSAutoScaleRun AutoScaleRun
        {
            get
            {
                if (((this.autoScaleRun == null) 
                            && (this.omObject.AutoScaleRun != null)))
                {
                    this.autoScaleRun = new PSAutoScaleRun(this.omObject.AutoScaleRun);
                }
                return this.autoScaleRun;
            }
        }
        
        public IList<PSCertificateReference> CertificateReferences
        {
            get
            {
                if (((this.certificateReferences == null) 
                            && (this.omObject.CertificateReferences != null)))
                {
                    List<PSCertificateReference> list;
                    list = new List<PSCertificateReference>();
                    IEnumerator<Microsoft.Azure.Batch.CertificateReference> enumerator;
                    enumerator = this.omObject.CertificateReferences.GetEnumerator();
                    for (
                    ; enumerator.MoveNext(); 
                    )
                    {
                        list.Add(new PSCertificateReference(enumerator.Current));
                    }
                    this.certificateReferences = list;
                }
                return this.certificateReferences;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.CertificateReferences = null;
                }
                else
                {
                    this.omObject.CertificateReferences = new List<Microsoft.Azure.Batch.CertificateReference>();
                }
                this.certificateReferences = value;
            }
        }
        
        public PSCloudServiceConfiguration CloudServiceConfiguration
        {
            get
            {
                if (((this.cloudServiceConfiguration == null) 
                            && (this.omObject.CloudServiceConfiguration != null)))
                {
                    this.cloudServiceConfiguration = new PSCloudServiceConfiguration(this.omObject.CloudServiceConfiguration);
                }
                return this.cloudServiceConfiguration;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.CloudServiceConfiguration = null;
                }
                else
                {
                    this.omObject.CloudServiceConfiguration = value.omObject;
                }
                this.cloudServiceConfiguration = value;
            }
        }
        
        public System.DateTime? CreationTime
        {
            get
            {
                return this.omObject.CreationTime;
            }
        }
        
        public System.Int32? CurrentDedicated
        {
            get
            {
                return this.omObject.CurrentDedicated;
            }
        }
        
        public string DisplayName
        {
            get
            {
                return this.omObject.DisplayName;
            }
            set
            {
                this.omObject.DisplayName = value;
            }
        }
        
        public string ETag
        {
            get
            {
                return this.omObject.ETag;
            }
        }
        
        public string Id
        {
            get
            {
                return this.omObject.Id;
            }
            set
            {
                this.omObject.Id = value;
            }
        }
        
        public System.Boolean? InterComputeNodeCommunicationEnabled
        {
            get
            {
                return this.omObject.InterComputeNodeCommunicationEnabled;
            }
            set
            {
                this.omObject.InterComputeNodeCommunicationEnabled = value;
            }
        }
        
        public System.DateTime? LastModified
        {
            get
            {
                return this.omObject.LastModified;
            }
        }
        
        public System.Int32? MaxTasksPerComputeNode
        {
            get
            {
                return this.omObject.MaxTasksPerComputeNode;
            }
            set
            {
                this.omObject.MaxTasksPerComputeNode = value;
            }
        }
        
        public IList<PSMetadataItem> Metadata
        {
            get
            {
                if (((this.metadata == null) 
                            && (this.omObject.Metadata != null)))
                {
                    List<PSMetadataItem> list;
                    list = new List<PSMetadataItem>();
                    IEnumerator<Microsoft.Azure.Batch.MetadataItem> enumerator;
                    enumerator = this.omObject.Metadata.GetEnumerator();
                    for (
                    ; enumerator.MoveNext(); 
                    )
                    {
                        list.Add(new PSMetadataItem(enumerator.Current));
                    }
                    this.metadata = list;
                }
                return this.metadata;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.Metadata = null;
                }
                else
                {
                    this.omObject.Metadata = new List<Microsoft.Azure.Batch.MetadataItem>();
                }
                this.metadata = value;
            }
        }
        
        public PSResizeError ResizeError
        {
            get
            {
                if (((this.resizeError == null) 
                            && (this.omObject.ResizeError != null)))
                {
                    this.resizeError = new PSResizeError(this.omObject.ResizeError);
                }
                return this.resizeError;
            }
        }
        
        public System.TimeSpan? ResizeTimeout
        {
            get
            {
                return this.omObject.ResizeTimeout;
            }
            set
            {
                this.omObject.ResizeTimeout = value;
            }
        }
        
        public PSStartTask StartTask
        {
            get
            {
                if (((this.startTask == null) 
                            && (this.omObject.StartTask != null)))
                {
                    this.startTask = new PSStartTask(this.omObject.StartTask);
                }
                return this.startTask;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.StartTask = null;
                }
                else
                {
                    this.omObject.StartTask = value.omObject;
                }
                this.startTask = value;
            }
        }
        
        public Microsoft.Azure.Batch.Common.PoolState? State
        {
            get
            {
                return this.omObject.State;
            }
        }
        
        public System.DateTime? StateTransitionTime
        {
            get
            {
                return this.omObject.StateTransitionTime;
            }
        }
        
        public PSPoolStatistics Statistics
        {
            get
            {
                if (((this.statistics == null) 
                            && (this.omObject.Statistics != null)))
                {
                    this.statistics = new PSPoolStatistics(this.omObject.Statistics);
                }
                return this.statistics;
            }
        }
        
        public System.Int32? TargetDedicated
        {
            get
            {
                return this.omObject.TargetDedicated;
            }
            set
            {
                this.omObject.TargetDedicated = value;
            }
        }
        
        public PSTaskSchedulingPolicy TaskSchedulingPolicy
        {
            get
            {
                if (((this.taskSchedulingPolicy == null) 
                            && (this.omObject.TaskSchedulingPolicy != null)))
                {
                    this.taskSchedulingPolicy = new PSTaskSchedulingPolicy(this.omObject.TaskSchedulingPolicy);
                }
                return this.taskSchedulingPolicy;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.TaskSchedulingPolicy = null;
                }
                else
                {
                    this.omObject.TaskSchedulingPolicy = value.omObject;
                }
                this.taskSchedulingPolicy = value;
            }
        }
        
        public string Url
        {
            get
            {
                return this.omObject.Url;
            }
        }
        
        public PSVirtualMachineConfiguration VirtualMachineConfiguration
        {
            get
            {
                if (((this.virtualMachineConfiguration == null) 
                            && (this.omObject.VirtualMachineConfiguration != null)))
                {
                    this.virtualMachineConfiguration = new PSVirtualMachineConfiguration(this.omObject.VirtualMachineConfiguration);
                }
                return this.virtualMachineConfiguration;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.VirtualMachineConfiguration = null;
                }
                else
                {
                    this.omObject.VirtualMachineConfiguration = value.omObject;
                }
                this.virtualMachineConfiguration = value;
            }
        }
        
        public string VirtualMachineSize
        {
            get
            {
                return this.omObject.VirtualMachineSize;
            }
            set
            {
                this.omObject.VirtualMachineSize = value;
            }
        }
    }
}
