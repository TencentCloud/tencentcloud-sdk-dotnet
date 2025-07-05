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

namespace TencentCloud.Ump.V20200918.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateProgramStateRequest : AbstractModel
    {
        
        /// <summary>
        /// 集团编码
        /// </summary>
        [JsonProperty("GroupCode")]
        public string GroupCode{ get; set; }

        /// <summary>
        /// 进程监控信息列表
        /// </summary>
        [JsonProperty("ProgramStateItems")]
        public ProgramStateItem[] ProgramStateItems{ get; set; }

        /// <summary>
        /// 商场ID
        /// </summary>
        [JsonProperty("MallId")]
        public ulong? MallId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupCode", this.GroupCode);
            this.SetParamArrayObj(map, prefix + "ProgramStateItems.", this.ProgramStateItems);
            this.SetParamSimple(map, prefix + "MallId", this.MallId);
        }
    }
}

