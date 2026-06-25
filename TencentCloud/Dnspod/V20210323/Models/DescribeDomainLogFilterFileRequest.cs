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

namespace TencentCloud.Dnspod.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDomainLogFilterFileRequest : AbstractModel
    {
        
        /// <summary>
        /// 要获取操作日志的域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 要获取操作日志的域名 Id，如果传了 DomainId，系统将会忽略 Domain 参数。 可以通过接口 DescribeDomainList 查到所有的 Domain 以及 DomainId
        /// </summary>
        [JsonProperty("DomainId")]
        public ulong? DomainId{ get; set; }

        /// <summary>
        /// 通过关键字搜索，支持搜索字段：账户 UIN、操作 IP、操作内容
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// 操作时间范围起始时间(仅支持近6个月的日志查询)
        /// </summary>
        [JsonProperty("OperateBegin")]
        public string OperateBegin{ get; set; }

        /// <summary>
        /// 操作时间范围截止时间(仅支持近6个月的日志查询)
        /// </summary>
        [JsonProperty("OperateEnd")]
        public string OperateEnd{ get; set; }

        /// <summary>
        /// 操作账号 UIN 精确匹配
        /// </summary>
        [JsonProperty("OperateUin")]
        public ulong? OperateUin{ get; set; }

        /// <summary>
        /// 操作 IP 精确匹配
        /// </summary>
        [JsonProperty("OperateClientIP")]
        public string OperateClientIP{ get; set; }

        /// <summary>
        /// 操作内容 模糊匹配
        /// </summary>
        [JsonProperty("OperateContent")]
        public string OperateContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamSimple(map, prefix + "OperateBegin", this.OperateBegin);
            this.SetParamSimple(map, prefix + "OperateEnd", this.OperateEnd);
            this.SetParamSimple(map, prefix + "OperateUin", this.OperateUin);
            this.SetParamSimple(map, prefix + "OperateClientIP", this.OperateClientIP);
            this.SetParamSimple(map, prefix + "OperateContent", this.OperateContent);
        }
    }
}

