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

namespace TencentCloud.Tsi.V20210325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TongChuanDisplayRequest : AbstractModel
    {
        
        /// <summary>
        /// 一段完整的语音对应一个SessionUuid
        /// </summary>
        [JsonProperty("SessionUuid")]
        public string SessionUuid{ get; set; }

        /// <summary>
        /// 句子排序方式，1-由新到旧
        /// </summary>
        [JsonProperty("IsNew")]
        public ulong? IsNew{ get; set; }

        /// <summary>
        /// 最多返回几句，目前只支持 5 条数据
        /// </summary>
        [JsonProperty("SeMax")]
        public ulong? SeMax{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SessionUuid", this.SessionUuid);
            this.SetParamSimple(map, prefix + "IsNew", this.IsNew);
            this.SetParamSimple(map, prefix + "SeMax", this.SeMax);
        }
    }
}

