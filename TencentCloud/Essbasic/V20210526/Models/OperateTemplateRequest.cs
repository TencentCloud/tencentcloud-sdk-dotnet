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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OperateTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 关于渠道应用的相关信息，包括渠道应用标识、第三方平台子客企业标识及第三方平台子客企业中的员工标识等内容，您可以参阅开发者中心所提供的 Agent 结构体以获取详细定义。
        /// 
        /// 此接口下面信息必填。
        /// <ul>
        /// <li>渠道应用标识:  Agent.AppId</li>
        /// <li>第三方平台子客企业标识: Agent.ProxyOrganizationOpenId（模板的归属企业）</li>
        /// <li>第三方平台子客企业中的员工标识: Agent.ProxyOperator.OpenId （操作人）</li>
        /// </ul>
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 模板ID，为32位字符串。
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 操作类型，可取值如下:
        /// <ul>
        /// <li>DELETE:  删除</li>
        /// <li>ENABLE: 启用</li>
        /// <li>DISABLE: 停用</li>
        /// <li>COPY: 复制新建</li>
        /// </ul>
        /// </summary>
        [JsonProperty("OperateType")]
        public string OperateType{ get; set; }

        /// <summary>
        /// 模板名称，长度不超过64字符。<br>
        /// 模板复制时指定有效，若为空，则复制后模板名称为 **原模板名称_副本**。
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "OperateType", this.OperateType);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
        }
    }
}

