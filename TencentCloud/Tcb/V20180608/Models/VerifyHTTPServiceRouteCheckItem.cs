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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VerifyHTTPServiceRouteCheckItem : AbstractModel
    {
        
        /// <summary>
        /// <p>检查状态</p><p>枚举值：</p><ul><li>PASS： 通过</li><li>SKIPPED： 跳过（无需校验，视为通过）</li><li>FAIL： 失败</li></ul><p>默认值：SKIPPED</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>前置校验子项失败原因枚举，仅在 Status=FAIL 时有值，供前端根据 Code 精确渲染提示与操作指引</p><p>枚举值：</p><ul><li>INTERNAL_CHECK_ERROR： 预检过程中依赖服务/内部资源异常</li><li>OWNERSHIP_DNS_LOOKUP_FAILED： DNS解析失败</li><li>OWNERSHIP_VERIFY_FAILED： DNS记录内容与预期dns记录值不匹配</li><li>CERT_VERIFY_FAILED： 证书校验失败：不匹配当前域名 / 已过期 / 不属于当前 uin 等</li><li>QUOTA_EXCEEDED： 域名或路径数量超出配额限制</li><li>ROUTE_CONFLICT： 存在同域名下已被占用的路径，前端应提示用户修改路径</li><li>DOMAIN_IN_USE： 域名已被其他环境占用，无法在当前环境接入</li><li>NON_INTERNAL_ACCOUNT： 使用了内部域名但当前账号不是内部账号</li><li>DOMAIN_IN_BLACKLIST： 域名被列入黑名单，禁止接入</li><li>CDN_RESOURCE_PROCESSING： CDN 资源正处于变更中，需稍后重试</li><li>CDN_RESOURCE_OFFLINE： CDN 资源已下线，需重新上线后才能绑定</li><li>EO_OWNERSHIP_VERIFY_FAILED： EdgeOne 侧归属权未通过，响应体中 OwnershipVerification 会给出，EdgeOne要求配置的 DNS/文件 verification 指引</li><li>EO_DOMAIN_NOT_ICP： EdgeOne 检测到域名未备案</li><li>EO_DOMAIN_IN_USE： EdgeOne 检测到域名已被其他账号接入 EdgeOne</li></ul>
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// <p>详细描述；Skipped 时给出跳过原因；Pass 时可为空</p>
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// <p>域名归属权验证指引信息，仅在所有权校验未通过时有值</p>
        /// </summary>
        [JsonProperty("OwnershipVerification")]
        public OwnershipVerificationInfo OwnershipVerification{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamObj(map, prefix + "OwnershipVerification.", this.OwnershipVerification);
        }
    }
}

