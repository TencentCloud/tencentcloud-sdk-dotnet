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

namespace TencentCloud.Ticm.V20181127.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageModerationResponse : AbstractModel
    {
        
        /// <summary>
        /// 识别场景的审核结论：
        /// PASS：正常
        /// REVIEW：疑似
        /// BLOCK：违规
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// 色情识别结果。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PornResult")]
        public PornResult PornResult{ get; set; }

        /// <summary>
        /// 暴恐识别结果。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TerrorismResult")]
        public TerrorismResult TerrorismResult{ get; set; }

        /// <summary>
        /// 政治敏感识别结果。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PoliticsResult")]
        public PoliticsResult PoliticsResult{ get; set; }

        /// <summary>
        /// 透传字段，透传简单信息。
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }

        /// <summary>
        /// 恶心内容识别结果。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DisgustResult")]
        public DisgustResult DisgustResult{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamObj(map, prefix + "PornResult.", this.PornResult);
            this.SetParamObj(map, prefix + "TerrorismResult.", this.TerrorismResult);
            this.SetParamObj(map, prefix + "PoliticsResult.", this.PoliticsResult);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
            this.SetParamObj(map, prefix + "DisgustResult.", this.DisgustResult);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

