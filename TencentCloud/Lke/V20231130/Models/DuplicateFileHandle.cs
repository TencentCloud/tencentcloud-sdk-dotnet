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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DuplicateFileHandle : AbstractModel
    {
        
        /// <summary>
        /// 重复文档判断方式，1：按文档内容，即cos_hash字段判断是否重复
        /// </summary>
        [JsonProperty("CheckType")]
        public ulong? CheckType{ get; set; }

        /// <summary>
        /// 重复文档处理方式，1：返回报错，2：跳过，返回重复的文档业务ID
        /// </summary>
        [JsonProperty("HandleType")]
        public ulong? HandleType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CheckType", this.CheckType);
            this.SetParamSimple(map, prefix + "HandleType", this.HandleType);
        }
    }
}

