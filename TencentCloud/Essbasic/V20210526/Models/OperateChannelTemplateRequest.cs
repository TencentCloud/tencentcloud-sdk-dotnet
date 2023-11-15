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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OperateChannelTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 关于渠道应用的相关信息，包括渠道应用标识、第三方平台子客企业标识及第三方平台子客企业中的员工标识等内容，您可以参阅开发者中心所提供的 Agent 结构体以获取详细定义。
        /// 
        /// 此接口下面信息必填。
        /// <ul>
        /// <li>第三方平台子客企业中的员工标识: Agent.AppId</li>
        /// </ul>
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 操作类型，可取值如下:
        /// <ul>
        /// <li>SELECT:  查询</li>
        /// <li>DELETE:  删除</li>
        /// <li>UPDATE: 更新</li>
        /// </ul>
        /// </summary>
        [JsonProperty("OperateType")]
        public string OperateType{ get; set; }

        /// <summary>
        /// 合同模板ID，为32位字符串。
        /// 注: ` 此处为第三方应用平台模板库模板ID，非子客模板ID`
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 第三方平台子客企业的唯一标识，支持批量(用,分割)，
        /// </summary>
        [JsonProperty("ProxyOrganizationOpenIds")]
        public string ProxyOrganizationOpenIds{ get; set; }

        /// <summary>
        /// 模板可见范围, 可以设置的值如下:
        /// 
        /// **all**: 所有本第三方应用合作企业可见
        /// **part**: 指定的本第三方应用合作企业
        /// 
        /// 对应控制台的位置
        /// ![image](https://qcloudimg.tencent-cloud.cn/raw/68b97812c68d6af77a5991e3bff5c790.png)
        /// </summary>
        [JsonProperty("AuthTag")]
        public string AuthTag{ get; set; }

        /// <summary>
        /// 当OperateType=UPDATE时，可以通过设置此字段对模板启停用状态进行操作。
        /// <ul>
        /// <li>0: 不修改模板可用状态</li>
        /// <li>1:  启用模板</li>
        /// <li>2: 停用模板</li>
        /// </ul>
        /// 启用后模板可以正常领取。
        /// 
        /// 停用后，推送方式为【自动推送】的模板则无法被子客使用，推送方式为【手动领取】的模板则无法出现被模板库被子客领用。
        /// 如果Available更新失败，会直接返回错误。
        /// </summary>
        [JsonProperty("Available")]
        public long? Available{ get; set; }

        /// <summary>
        /// 暂未开放
        /// </summary>
        [JsonProperty("Operator")]
        [System.Obsolete]
        public UserInfo Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "OperateType", this.OperateType);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "ProxyOrganizationOpenIds", this.ProxyOrganizationOpenIds);
            this.SetParamSimple(map, prefix + "AuthTag", this.AuthTag);
            this.SetParamSimple(map, prefix + "Available", this.Available);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
        }
    }
}

