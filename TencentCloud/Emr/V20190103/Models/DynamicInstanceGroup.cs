/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DynamicInstanceGroup : AbstractModel
    {
        
        /// <summary>
        /// <p>资源组类型</p>
        /// </summary>
        [JsonProperty("GroupType")]
        public string GroupType{ get; set; }

        /// <summary>
        /// <p>资源组名称</p>
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// <p>pod cpu核数</p>
        /// </summary>
        [JsonProperty("PodCpu")]
        public ulong? PodCpu{ get; set; }

        /// <summary>
        /// <p>pod mem大小（GB）</p>
        /// </summary>
        [JsonProperty("PodMem")]
        public ulong? PodMem{ get; set; }

        /// <summary>
        /// <p>pod gpu类型</p>
        /// </summary>
        [JsonProperty("PodGpuType")]
        public string PodGpuType{ get; set; }

        /// <summary>
        /// <p>pod gpu块数</p>
        /// </summary>
        [JsonProperty("PodGpu")]
        public ulong? PodGpu{ get; set; }

        /// <summary>
        /// <p>pod个数</p>
        /// </summary>
        [JsonProperty("PodNum")]
        public ulong? PodNum{ get; set; }

        /// <summary>
        /// <p>pod弹性最小个数</p>
        /// </summary>
        [JsonProperty("MinPodNum")]
        public ulong? MinPodNum{ get; set; }

        /// <summary>
        /// <p>pod弹性最大个数，当MaxPodNum &gt; MinPodNum时，默认表示开启弹性扩缩容，将在范围内扩缩容</p>
        /// </summary>
        [JsonProperty("MaxPodNum")]
        public ulong? MaxPodNum{ get; set; }

        /// <summary>
        /// <p>是否支持存储配置</p>
        /// </summary>
        [JsonProperty("SupportPV")]
        public bool? SupportPV{ get; set; }

        /// <summary>
        /// <p>cbs存储卷列表</p>
        /// </summary>
        [JsonProperty("CBSVolumes")]
        public CBSVolume[] CBSVolumes{ get; set; }

        /// <summary>
        /// <p>cfs存储卷列表</p>
        /// </summary>
        [JsonProperty("CFSVolumes")]
        public CFSVolume[] CFSVolumes{ get; set; }

        /// <summary>
        /// <p>cos存储卷列表</p>
        /// </summary>
        [JsonProperty("COSVolumes")]
        public COSVolume[] COSVolumes{ get; set; }

        /// <summary>
        /// <p>挂载卷列表</p>
        /// </summary>
        [JsonProperty("VolumeMounts")]
        public VolumeMount[] VolumeMounts{ get; set; }

        /// <summary>
        /// <p>pod标签</p>
        /// </summary>
        [JsonProperty("Labels")]
        public TkeLabel[] Labels{ get; set; }

        /// <summary>
        /// <p>Tolerations定义</p>
        /// </summary>
        [JsonProperty("Tolerations")]
        public Toleration[] Tolerations{ get; set; }

        /// <summary>
        /// <p>环境变量</p>
        /// </summary>
        [JsonProperty("Envs")]
        public NameValue[] Envs{ get; set; }

        /// <summary>
        /// <p>节点调度策略</p>
        /// </summary>
        [JsonProperty("SchedulingPolicy")]
        public string SchedulingPolicy{ get; set; }

        /// <summary>
        /// <p>资源标签</p>
        /// </summary>
        [JsonProperty("ResourceLabel")]
        public string ResourceLabel{ get; set; }

        /// <summary>
        /// <p>GPU资源厂商key</p>
        /// </summary>
        [JsonProperty("PodGpuResourceKey")]
        public string PodGpuResourceKey{ get; set; }

        /// <summary>
        /// <p>CFS Turbo 挂载列表</p>
        /// </summary>
        [JsonProperty("CFSTurboVolumes")]
        public CFSTurboVolume[] CFSTurboVolumes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupType", this.GroupType);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "PodCpu", this.PodCpu);
            this.SetParamSimple(map, prefix + "PodMem", this.PodMem);
            this.SetParamSimple(map, prefix + "PodGpuType", this.PodGpuType);
            this.SetParamSimple(map, prefix + "PodGpu", this.PodGpu);
            this.SetParamSimple(map, prefix + "PodNum", this.PodNum);
            this.SetParamSimple(map, prefix + "MinPodNum", this.MinPodNum);
            this.SetParamSimple(map, prefix + "MaxPodNum", this.MaxPodNum);
            this.SetParamSimple(map, prefix + "SupportPV", this.SupportPV);
            this.SetParamArrayObj(map, prefix + "CBSVolumes.", this.CBSVolumes);
            this.SetParamArrayObj(map, prefix + "CFSVolumes.", this.CFSVolumes);
            this.SetParamArrayObj(map, prefix + "COSVolumes.", this.COSVolumes);
            this.SetParamArrayObj(map, prefix + "VolumeMounts.", this.VolumeMounts);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamArrayObj(map, prefix + "Tolerations.", this.Tolerations);
            this.SetParamArrayObj(map, prefix + "Envs.", this.Envs);
            this.SetParamSimple(map, prefix + "SchedulingPolicy", this.SchedulingPolicy);
            this.SetParamSimple(map, prefix + "ResourceLabel", this.ResourceLabel);
            this.SetParamSimple(map, prefix + "PodGpuResourceKey", this.PodGpuResourceKey);
            this.SetParamArrayObj(map, prefix + "CFSTurboVolumes.", this.CFSTurboVolumes);
        }
    }
}

