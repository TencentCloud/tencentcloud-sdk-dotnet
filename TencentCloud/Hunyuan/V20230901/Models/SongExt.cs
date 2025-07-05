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

namespace TencentCloud.Hunyuan.V20230901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SongExt : AbstractModel
    {
        
        /// <summary>
        /// 歌曲id
        /// </summary>
        [JsonProperty("SongId")]
        public long? SongId{ get; set; }

        /// <summary>
        /// 歌曲mid
        /// </summary>
        [JsonProperty("SongMid")]
        public string SongMid{ get; set; }

        /// <summary>
        /// 歌曲是否为vip。1：vip歌曲； 0：普通歌曲。
        /// </summary>
        [JsonProperty("Vip")]
        public long? Vip{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SongId", this.SongId);
            this.SetParamSimple(map, prefix + "SongMid", this.SongMid);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
        }
    }
}

