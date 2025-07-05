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

namespace TencentCloud.Iotvideo.V20211125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSDKLogRequest : AbstractModel
    {
        
        /// <summary>
        /// 日志开始时间
        /// </summary>
        [JsonProperty("MinTime")]
        public ulong? MinTime{ get; set; }

        /// <summary>
        /// 日志结束时间
        /// </summary>
        [JsonProperty("MaxTime")]
        public ulong? MaxTime{ get; set; }

        /// <summary>
        /// 查询关键字，可以同时支持键值查询和文本查询，
        /// 例如，查询某key的值为value，并且包含某word的日志，该参数为：key:value word。
        /// 键值或文本可以包含多个，以空格隔开。
        /// 其中可以索引的key包括：productid、devicename、loglevel
        /// 一个典型的查询示例：productid:7JK1G72JNE devicename:name publish loglevel:WARN一个典型的查询示例：productid:ABCDE12345 devicename:test scene:SHADOW publish
        /// </summary>
        [JsonProperty("Keywords")]
        public string Keywords{ get; set; }

        /// <summary>
        /// 日志检索上下文
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }

        /// <summary>
        /// 查询条数
        /// </summary>
        [JsonProperty("MaxNum")]
        public ulong? MaxNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MinTime", this.MinTime);
            this.SetParamSimple(map, prefix + "MaxTime", this.MaxTime);
            this.SetParamSimple(map, prefix + "Keywords", this.Keywords);
            this.SetParamSimple(map, prefix + "Context", this.Context);
            this.SetParamSimple(map, prefix + "MaxNum", this.MaxNum);
        }
    }
}

