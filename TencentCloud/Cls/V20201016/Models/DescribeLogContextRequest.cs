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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLogContextRequest : AbstractModel
    {
        
        /// <summary>
        /// 要查询的日志主题ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 日志时间,  格式: YYYY-mm-dd HH:MM:SS.FFF
        /// </summary>
        [JsonProperty("BTime")]
        public string BTime{ get; set; }

        /// <summary>
        /// 日志包序号。SearchLog接口返回信息中Results结构体中的PkgId。
        /// </summary>
        [JsonProperty("PkgId")]
        public string PkgId{ get; set; }

        /// <summary>
        /// 日志包内一条日志的序号。
        /// SearchLog接口返回信息中Results结构中的PkgLogId。
        /// </summary>
        [JsonProperty("PkgLogId")]
        public long? PkgLogId{ get; set; }

        /// <summary>
        /// 前${PrevLogs}条日志，默认值10。
        /// </summary>
        [JsonProperty("PrevLogs")]
        public long? PrevLogs{ get; set; }

        /// <summary>
        /// 后${NextLogs}条日志，默认值10。
        /// </summary>
        [JsonProperty("NextLogs")]
        public long? NextLogs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "BTime", this.BTime);
            this.SetParamSimple(map, prefix + "PkgId", this.PkgId);
            this.SetParamSimple(map, prefix + "PkgLogId", this.PkgLogId);
            this.SetParamSimple(map, prefix + "PrevLogs", this.PrevLogs);
            this.SetParamSimple(map, prefix + "NextLogs", this.NextLogs);
        }
    }
}

