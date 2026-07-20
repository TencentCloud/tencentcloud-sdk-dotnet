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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class App : AbstractModel
    {
        
        /// <summary>
        /// <p>辅助信息(子状态/审批/申诉/搜索资源/特殊状态等)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuxiliaryInfo")]
        public AppAuxiliaryInfo AuxiliaryInfo{ get; set; }

        /// <summary>
        /// <p>配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Config")]
        public AppConfig Config{ get; set; }

        /// <summary>
        /// <p>元数据</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Metadata")]
        public AppMetadata Metadata{ get; set; }

        /// <summary>
        /// <p>应用密钥信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecretInfo")]
        public AppSecretInfo SecretInfo{ get; set; }

        /// <summary>
        /// <p>分享链接信息(含访问控制)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShareUrlInfo")]
        public AppShareURLInfo ShareUrlInfo{ get; set; }

        /// <summary>
        /// <p>状态</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public AppStatusInfo Status{ get; set; }

        /// <summary>
        /// <p>应用引用的共享知识库列表</p>
        /// </summary>
        [JsonProperty("SharedKbList")]
        public AppSharedKbInfo[] SharedKbList{ get; set; }

        /// <summary>
        /// <p>企业共享配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CorpShareConfig")]
        public CorpShareConfig CorpShareConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "AuxiliaryInfo.", this.AuxiliaryInfo);
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamObj(map, prefix + "Metadata.", this.Metadata);
            this.SetParamObj(map, prefix + "SecretInfo.", this.SecretInfo);
            this.SetParamObj(map, prefix + "ShareUrlInfo.", this.ShareUrlInfo);
            this.SetParamObj(map, prefix + "Status.", this.Status);
            this.SetParamArrayObj(map, prefix + "SharedKbList.", this.SharedKbList);
            this.SetParamObj(map, prefix + "CorpShareConfig.", this.CorpShareConfig);
        }
    }
}

