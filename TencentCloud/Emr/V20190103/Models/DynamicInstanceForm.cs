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

    public class DynamicInstanceForm : AbstractModel
    {
        
        /// <summary>
        /// <p>DynamicInstance名，长度限制1-64字符，只能包含小写字母</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DynamicInstanceName")]
        public string DynamicInstanceName{ get; set; }

        /// <summary>
        /// <p>命名空间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// <p>是否支持高可用</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SupportHA")]
        public bool? SupportHA{ get; set; }

        /// <summary>
        /// <p>自定义镜像信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomImage")]
        public CustomImage CustomImage{ get; set; }

        /// <summary>
        /// <p>资源组配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DynamicInstanceGroups")]
        public DynamicInstanceGroup[] DynamicInstanceGroups{ get; set; }

        /// <summary>
        /// <p>是否支持存储配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SupportPV")]
        public bool? SupportPV{ get; set; }

        /// <summary>
        /// <p>cbs存储卷列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CBSVolumes")]
        public CBSVolume[] CBSVolumes{ get; set; }

        /// <summary>
        /// <p>cfs存储卷列表，只包含cfs，不包含cfs turbo</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CFSVolumes")]
        public CFSVolume[] CFSVolumes{ get; set; }

        /// <summary>
        /// <p>cos存储卷列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("COSVolumes")]
        public COSVolume[] COSVolumes{ get; set; }

        /// <summary>
        /// <p>挂载卷列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VolumeMounts")]
        public VolumeMount[] VolumeMounts{ get; set; }

        /// <summary>
        /// <p>pod标签</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Labels")]
        public TkeLabel[] Labels{ get; set; }

        /// <summary>
        /// <p>Tolerations定义</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tolerations")]
        public Toleration[] Tolerations{ get; set; }

        /// <summary>
        /// <p>环境变量</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Envs")]
        public NameValue[] Envs{ get; set; }

        /// <summary>
        /// <p>依赖外部组件</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DependServices")]
        public DependService[] DependServices{ get; set; }

        /// <summary>
        /// <p>是否开启token鉴权</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SupportToken")]
        public bool? SupportToken{ get; set; }

        /// <summary>
        /// <p>cfs trubo挂载列表，不包含标准版cfs</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CFSTurboVolumes")]
        public CFSTurboVolume[] CFSTurboVolumes{ get; set; }

        /// <summary>
        /// <p>自定义镜像</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageInfoV2")]
        public ImageInfoV2 ImageInfoV2{ get; set; }

        /// <summary>
        /// <p>GooseFS盘</p>
        /// </summary>
        [JsonProperty("GooseFSVolumes")]
        public GooseFSVolume[] GooseFSVolumes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DynamicInstanceName", this.DynamicInstanceName);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "SupportHA", this.SupportHA);
            this.SetParamObj(map, prefix + "CustomImage.", this.CustomImage);
            this.SetParamArrayObj(map, prefix + "DynamicInstanceGroups.", this.DynamicInstanceGroups);
            this.SetParamSimple(map, prefix + "SupportPV", this.SupportPV);
            this.SetParamArrayObj(map, prefix + "CBSVolumes.", this.CBSVolumes);
            this.SetParamArrayObj(map, prefix + "CFSVolumes.", this.CFSVolumes);
            this.SetParamArrayObj(map, prefix + "COSVolumes.", this.COSVolumes);
            this.SetParamArrayObj(map, prefix + "VolumeMounts.", this.VolumeMounts);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamArrayObj(map, prefix + "Tolerations.", this.Tolerations);
            this.SetParamArrayObj(map, prefix + "Envs.", this.Envs);
            this.SetParamArrayObj(map, prefix + "DependServices.", this.DependServices);
            this.SetParamSimple(map, prefix + "SupportToken", this.SupportToken);
            this.SetParamArrayObj(map, prefix + "CFSTurboVolumes.", this.CFSTurboVolumes);
            this.SetParamObj(map, prefix + "ImageInfoV2.", this.ImageInfoV2);
            this.SetParamArrayObj(map, prefix + "GooseFSVolumes.", this.GooseFSVolumes);
        }
    }
}

