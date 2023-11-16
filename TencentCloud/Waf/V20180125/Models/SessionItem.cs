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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SessionItem : AbstractModel
    {
        
        /// <summary>
        /// 匹配类型
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// 起始模式
        /// </summary>
        [JsonProperty("KeyOrStartMat")]
        public string KeyOrStartMat{ get; set; }

        /// <summary>
        /// 结束模式
        /// </summary>
        [JsonProperty("EndMat")]
        public string EndMat{ get; set; }

        /// <summary>
        /// 起始偏移
        /// </summary>
        [JsonProperty("StartOffset")]
        public string StartOffset{ get; set; }

        /// <summary>
        /// 结束偏移
        /// </summary>
        [JsonProperty("EndOffset")]
        public string EndOffset{ get; set; }

        /// <summary>
        /// 数据源
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 更新时间戳
        /// </summary>
        [JsonProperty("TsVersion")]
        public string TsVersion{ get; set; }

        /// <summary>
        /// SessionID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SessionId")]
        public long? SessionId{ get; set; }

        /// <summary>
        /// Session名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SessionName")]
        public string SessionName{ get; set; }

        /// <summary>
        /// Session是否正在被启用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SessionInUsed")]
        public bool? SessionInUsed{ get; set; }

        /// <summary>
        /// Session关联的CC规则ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelatedRuleID")]
        public long?[] RelatedRuleID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "KeyOrStartMat", this.KeyOrStartMat);
            this.SetParamSimple(map, prefix + "EndMat", this.EndMat);
            this.SetParamSimple(map, prefix + "StartOffset", this.StartOffset);
            this.SetParamSimple(map, prefix + "EndOffset", this.EndOffset);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "TsVersion", this.TsVersion);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionName", this.SessionName);
            this.SetParamSimple(map, prefix + "SessionInUsed", this.SessionInUsed);
            this.SetParamArraySimple(map, prefix + "RelatedRuleID.", this.RelatedRuleID);
        }
    }
}

