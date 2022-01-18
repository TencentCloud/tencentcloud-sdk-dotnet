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

namespace TencentCloud.Ame.V20190916.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetPlaylistCommandInput : AbstractModel
    {
        
        /// <summary>
        /// 变更类型，取值有：
        /// <li>Add：添加</li>
        /// <li>Delete：删除</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 歌单索引位置，
        /// 当 Type 取 Add 时，-1表示添加在列表最后位置，大于-1表示要添加的位置；
        /// 当 Type 取 Delete 时，表示要删除的位置。
        /// </summary>
        [JsonProperty("Index")]
        public long? Index{ get; set; }

        /// <summary>
        /// 歌曲 ID 列表，当 Type 取 Add 时，必填。
        /// </summary>
        [JsonProperty("MusicIds")]
        public string[] MusicIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Index", this.Index);
            this.SetParamArraySimple(map, prefix + "MusicIds.", this.MusicIds);
        }
    }
}

