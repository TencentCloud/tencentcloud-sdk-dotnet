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

    public class ChannelCreateConvertTaskApiRequest : AbstractModel
    {
        
        /// <summary>
        /// 关于渠道应用的相关信息，包括渠道应用标识、第三方平台子客企业标识及第三方平台子客企业中的员工标识等内容，您可以参阅开发者中心所提供的 Agent 结构体以获取详细定义。
        /// 
        /// 此接口下面信息必填。
        /// <ul>
        /// <li>渠道应用标识:  Agent.AppId</li>
        /// <li>第三方平台子客企业标识: Agent.ProxyOrganizationOpenId</li>
        /// <li>第三方平台子客企业中的员工标识: Agent. ProxyOperator.OpenId</li>
        /// </ul>
        /// 第三方平台子客企业和员工必须已经经过实名认证
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 需要进行转换的资源文件类型
        /// 支持的文件类型如下：
        /// <ul><li>doc</li>
        /// <li>docx</li>
        /// <li>xls</li>
        /// <li>xlsx</li>
        /// <li>jpg</li>
        /// <li>jpeg</li>
        /// <li>png</li>
        /// <li>bmp</li>
        /// <li>html</li>
        /// <li>txt</li></ul>
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// 需要进行转换操作的文件资源名称，带资源后缀名。
        /// 
        /// 注:  `资源名称长度限制为256个字符`
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// 需要进行转换操作的文件资源Id，通过<a href="https://qian.tencent.com/developers/partnerApis/files/UploadFiles" target="_blank">UploadFiles</a>接口获取文件资源Id。
        /// 
        /// 注:  `目前，此接口仅支持单个文件进行转换。`
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 调用方用户信息，不用传
        /// </summary>
        [JsonProperty("Operator")]
        [System.Obsolete]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 暂未开放
        /// </summary>
        [JsonProperty("Organization")]
        [System.Obsolete]
        public OrganizationInfo Organization{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamObj(map, prefix + "Organization.", this.Organization);
        }
    }
}

