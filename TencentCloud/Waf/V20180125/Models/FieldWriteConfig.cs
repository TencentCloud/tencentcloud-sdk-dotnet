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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FieldWriteConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>1:开启 0:不开启</p>
        /// </summary>
        [JsonProperty("EnableHeaders")]
        public long? EnableHeaders{ get; set; }

        /// <summary>
        /// <p>1:开启 0:不开启</p>
        /// </summary>
        [JsonProperty("EnableBody")]
        public long? EnableBody{ get; set; }

        /// <summary>
        /// <p>仅当该条访问日志命中攻击规则时，是否额外存储 attack_body 字段（取值与 body 字段相同）。1:开启 0/不填:不开启。与 EnableBody 完全独立，互不影响。仅在存储查询链路（DescribeAccessMeta/ModifyAccessPeriod）中生效，不影响 CLS/CKafka 自定义投递（CreatePostCLSFlow/CreatePostCKafkaFlow）配置。</p>
        /// </summary>
        [JsonProperty("EnableAttackBody")]
        public long? EnableAttackBody{ get; set; }

        /// <summary>
        /// <p>1:开启 0:不开启</p>
        /// </summary>
        [JsonProperty("EnableBot")]
        public long? EnableBot{ get; set; }

        /// <summary>
        /// <p>响应方向body<br>1:开启 0:不开启</p>
        /// </summary>
        [JsonProperty("EnableResponse")]
        public long? EnableResponse{ get; set; }

        /// <summary>
        /// <p>是否投递 response_headers（响应头，完整键值对，原样投递不做过滤/脱敏，超过2KB截断）。1:开启 0/不填:不开启。与 EnableResponse（响应体）完全独立，互不影响。</p>
        /// </summary>
        [JsonProperty("EnableResponseHeaders")]
        public long? EnableResponseHeaders{ get; set; }

        /// <summary>
        /// <p>是否投递 response_length（响应包长度，单位字节）。1:开启 0/不填:不开启。与 EnableResponse 完全独立，互不影响。</p>
        /// </summary>
        [JsonProperty("EnableResponseLength")]
        public long? EnableResponseLength{ get; set; }

        /// <summary>
        /// <p>是否投递 response_status_line（客户端可见 HTTP 状态行，如 HTTP/1.1 200 OK，超过1KB截断）。1:开启 0/不填:不开启。与 EnableResponse 完全独立，互不影响。拦截/未回源时也会有值，记录的是 WAF 返回给客户端的状态行。</p>
        /// </summary>
        [JsonProperty("EnableResponseStatusLine")]
        public long? EnableResponseStatusLine{ get; set; }

        /// <summary>
        /// <p>大模型安全防护详情字段，用;分割，仅对 SDK 访问日志生效。不传表示全部写入；传空字符串表示只写必填字段（uuid、appid、instance、timestamp、llm_service_id）。</p>
        /// </summary>
        [JsonProperty("LlmItem")]
        public string LlmItem{ get; set; }

        /// <summary>
        /// <p>headers 字段中10个通用冗余子字段（accept/accept-encoding/accept-language/connection/content-type/cookie/host/referer/x-forwarded-for/user-agent）剔除开关。1:剔除 0/不填:不剔除。仅在CLS/CKafka自定义投递（CreatePostCLSFlow/CreatePostCKafkaFlow及对应Describe接口）中生效，不影响原有存储日志配置。</p>
        /// </summary>
        [JsonProperty("FilterPlusEnableHeaderFilter")]
        public long? FilterPlusEnableHeaderFilter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableHeaders", this.EnableHeaders);
            this.SetParamSimple(map, prefix + "EnableBody", this.EnableBody);
            this.SetParamSimple(map, prefix + "EnableAttackBody", this.EnableAttackBody);
            this.SetParamSimple(map, prefix + "EnableBot", this.EnableBot);
            this.SetParamSimple(map, prefix + "EnableResponse", this.EnableResponse);
            this.SetParamSimple(map, prefix + "EnableResponseHeaders", this.EnableResponseHeaders);
            this.SetParamSimple(map, prefix + "EnableResponseLength", this.EnableResponseLength);
            this.SetParamSimple(map, prefix + "EnableResponseStatusLine", this.EnableResponseStatusLine);
            this.SetParamSimple(map, prefix + "LlmItem", this.LlmItem);
            this.SetParamSimple(map, prefix + "FilterPlusEnableHeaderFilter", this.FilterPlusEnableHeaderFilter);
        }
    }
}

