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

namespace TencentCloud.Trocket.V20230308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SourceClusterGroupConfig : AbstractModel
    {
        
        /// <summary>
        /// 消费组名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 备注信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 是否已导入，作为入参时无效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Imported")]
        public bool? Imported{ get; set; }

        /// <summary>
        /// 命名空间，仅4.x集群有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 导入状态
        /// Unknown 未知
        /// Success 成功
        /// Failure 失败
        /// AlreadyExists 已存在
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImportStatus")]
        public string ImportStatus{ get; set; }

        /// <summary>
        /// 4.x的命名空间，出参使用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NamespaceV4")]
        public string NamespaceV4{ get; set; }

        /// <summary>
        /// 4.x的消费组名，出参使用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupNameV4")]
        public string GroupNameV4{ get; set; }

        /// <summary>
        /// 4.x的完整命名空间，出参使用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FullNamespaceV4")]
        public string FullNamespaceV4{ get; set; }

        /// <summary>
        /// 是否为顺序投递，5.0有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConsumeMessageOrderly")]
        public bool? ConsumeMessageOrderly{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Imported", this.Imported);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "ImportStatus", this.ImportStatus);
            this.SetParamSimple(map, prefix + "NamespaceV4", this.NamespaceV4);
            this.SetParamSimple(map, prefix + "GroupNameV4", this.GroupNameV4);
            this.SetParamSimple(map, prefix + "FullNamespaceV4", this.FullNamespaceV4);
            this.SetParamSimple(map, prefix + "ConsumeMessageOrderly", this.ConsumeMessageOrderly);
        }
    }
}

