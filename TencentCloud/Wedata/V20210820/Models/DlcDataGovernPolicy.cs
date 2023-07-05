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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DlcDataGovernPolicy : AbstractModel
    {
        
        /// <summary>
        /// 数据排布治理项
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RewriteDataPolicy")]
        public DlcRewriteDataInfo RewriteDataPolicy{ get; set; }

        /// <summary>
        /// 快照过期治理项
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpiredSnapshotsPolicy")]
        public DlcExpiredSnapshotsInfo ExpiredSnapshotsPolicy{ get; set; }

        /// <summary>
        /// 移除孤立文件治理项
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RemoveOrphanFilesPolicy")]
        public DlcRemoveOrphanFilesInfo RemoveOrphanFilesPolicy{ get; set; }

        /// <summary>
        /// 合并元数据Manifests治理项
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MergeManifestsPolicy")]
        public DlcMergeManifestsInfo MergeManifestsPolicy{ get; set; }

        /// <summary>
        /// 是否集成库规则：default（默认继承）、none（不继承）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InheritDataBase")]
        public string InheritDataBase{ get; set; }

        /// <summary>
        /// 治理规则类型，Customize: 自定义；Intelligence: 智能治理
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// 治理引擎
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GovernEngine")]
        public string GovernEngine{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "RewriteDataPolicy.", this.RewriteDataPolicy);
            this.SetParamObj(map, prefix + "ExpiredSnapshotsPolicy.", this.ExpiredSnapshotsPolicy);
            this.SetParamObj(map, prefix + "RemoveOrphanFilesPolicy.", this.RemoveOrphanFilesPolicy);
            this.SetParamObj(map, prefix + "MergeManifestsPolicy.", this.MergeManifestsPolicy);
            this.SetParamSimple(map, prefix + "InheritDataBase", this.InheritDataBase);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "GovernEngine", this.GovernEngine);
        }
    }
}

