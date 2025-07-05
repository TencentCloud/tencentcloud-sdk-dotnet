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

namespace TencentCloud.Yinsuda.V20220527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KTVMatchMusic : AbstractModel
    {
        
        /// <summary>
        /// 匹配到的歌曲基础信息。
        /// </summary>
        [JsonProperty("KTVMusicBaseInfo")]
        public KTVMusicBaseInfo KTVMusicBaseInfo{ get; set; }

        /// <summary>
        /// 命中规则。
        /// </summary>
        [JsonProperty("MatchRule")]
        public KTVMatchRule MatchRule{ get; set; }

        /// <summary>
        /// AME 歌曲基础信息，仅在使用音速达歌曲 Id 匹配 AME 曲库时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AMEMusicBaseInfo")]
        public AMEMusicBaseInfo AMEMusicBaseInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "KTVMusicBaseInfo.", this.KTVMusicBaseInfo);
            this.SetParamObj(map, prefix + "MatchRule.", this.MatchRule);
            this.SetParamObj(map, prefix + "AMEMusicBaseInfo.", this.AMEMusicBaseInfo);
        }
    }
}

