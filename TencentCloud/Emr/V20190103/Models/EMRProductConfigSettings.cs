/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class EMRProductConfigSettings : AbstractModel
    {
        
        /// <summary>
        /// 集群软件信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SoftInfo")]
        public string[] SoftInfo{ get; set; }

        /// <summary>
        /// master节点数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MasterNodeSize")]
        public ulong? MasterNodeSize{ get; set; }

        /// <summary>
        /// core节点数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CoreNodeSize")]
        public ulong? CoreNodeSize{ get; set; }

        /// <summary>
        /// task节点数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskNodeSize")]
        public ulong? TaskNodeSize{ get; set; }

        /// <summary>
        /// common节点数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ComNodeSize")]
        public ulong? ComNodeSize{ get; set; }

        /// <summary>
        /// master规格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MasterResourceSpec")]
        public NodeSpec MasterResourceSpec{ get; set; }

        /// <summary>
        /// core规格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CoreResourceSpec")]
        public NodeSpec CoreResourceSpec{ get; set; }

        /// <summary>
        /// task规格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskResourceSpec")]
        public NodeSpec TaskResourceSpec{ get; set; }

        /// <summary>
        /// common规格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CommonResourceSpec")]
        public NodeSpec CommonResourceSpec{ get; set; }

        /// <summary>
        /// 是否使用COS
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Oncos")]
        public bool? Oncos{ get; set; }

        /// <summary>
        /// COS配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("COSSettings")]
        public COSSettings COSSettings{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SoftInfo.", this.SoftInfo);
            this.SetParamSimple(map, prefix + "MasterNodeSize", this.MasterNodeSize);
            this.SetParamSimple(map, prefix + "CoreNodeSize", this.CoreNodeSize);
            this.SetParamSimple(map, prefix + "TaskNodeSize", this.TaskNodeSize);
            this.SetParamSimple(map, prefix + "ComNodeSize", this.ComNodeSize);
            this.SetParamObj(map, prefix + "MasterResourceSpec.", this.MasterResourceSpec);
            this.SetParamObj(map, prefix + "CoreResourceSpec.", this.CoreResourceSpec);
            this.SetParamObj(map, prefix + "TaskResourceSpec.", this.TaskResourceSpec);
            this.SetParamObj(map, prefix + "CommonResourceSpec.", this.CommonResourceSpec);
            this.SetParamSimple(map, prefix + "Oncos", this.Oncos);
            this.SetParamObj(map, prefix + "COSSettings.", this.COSSettings);
        }
    }
}

