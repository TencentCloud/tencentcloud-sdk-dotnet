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

    public class ModifyDynamicInstanceForm : AbstractModel
    {
        
        /// <summary>
        /// <p>更新作用域：<br>1：添加workerGroup（DynamicInstance级别）<br>2：更新存储配置（DynamicInstance级别）<br>3：更新标签配置（DynamicInstance级别）<br>4：更新高级配置（DynamicInstance级别）<br>5：更新PodCpu、PodMem（DynamicInstance-group级别）<br>6：更新PodNum、MinPodNum、MaxPodNum（DynamicInstance-group级别）<br>7：更新存储配置（DynamicInstance-group级别）<br>8：更新标签配置（DynamicInstance-group级别）</p>
        /// </summary>
        [JsonProperty("ModifyScope")]
        public long? ModifyScope{ get; set; }

        /// <summary>
        /// <p>添加的workerGroup信息</p>
        /// </summary>
        [JsonProperty("AddDynamicInstanceGroup")]
        public DynamicInstanceGroup AddDynamicInstanceGroup{ get; set; }

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
        /// <p>cfs存储卷列表，不包含cfs turbo列表</p>
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
        /// <p>依赖外部组件</p>
        /// </summary>
        [JsonProperty("DependServices")]
        public DependService[] DependServices{ get; set; }

        /// <summary>
        /// <p>是否生成新token鉴权</p>
        /// </summary>
        [JsonProperty("SupportNewToken")]
        public bool? SupportNewToken{ get; set; }

        /// <summary>
        /// <p>DynamicInstance-group级别的更新信息</p>
        /// </summary>
        [JsonProperty("ModifyDynamicInstanceGroup")]
        public DynamicInstanceGroup ModifyDynamicInstanceGroup{ get; set; }

        /// <summary>
        /// <p>cfs turbo挂载列表，不包含标准版</p>
        /// </summary>
        [JsonProperty("CFSTurboVolumes")]
        public CFSTurboVolume[] CFSTurboVolumes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModifyScope", this.ModifyScope);
            this.SetParamObj(map, prefix + "AddDynamicInstanceGroup.", this.AddDynamicInstanceGroup);
            this.SetParamSimple(map, prefix + "SupportPV", this.SupportPV);
            this.SetParamArrayObj(map, prefix + "CBSVolumes.", this.CBSVolumes);
            this.SetParamArrayObj(map, prefix + "CFSVolumes.", this.CFSVolumes);
            this.SetParamArrayObj(map, prefix + "COSVolumes.", this.COSVolumes);
            this.SetParamArrayObj(map, prefix + "VolumeMounts.", this.VolumeMounts);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamArrayObj(map, prefix + "Tolerations.", this.Tolerations);
            this.SetParamArrayObj(map, prefix + "Envs.", this.Envs);
            this.SetParamArrayObj(map, prefix + "DependServices.", this.DependServices);
            this.SetParamSimple(map, prefix + "SupportNewToken", this.SupportNewToken);
            this.SetParamObj(map, prefix + "ModifyDynamicInstanceGroup.", this.ModifyDynamicInstanceGroup);
            this.SetParamArrayObj(map, prefix + "CFSTurboVolumes.", this.CFSTurboVolumes);
        }
    }
}

