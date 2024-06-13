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

    public class ChannelCreateEmbedWebUrlRequest : AbstractModel
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
        /// 要生成WEB嵌入界面的类型, 可以选择的值如下: 
        /// 
        /// <ul>
        /// <li>CREATE_SEAL: 生成创建印章的嵌入页面</li>
        /// <li>CREATE_TEMPLATE：生成创建模板的嵌入页面</li>
        /// <li>MODIFY_TEMPLATE：生成修改模板的嵌入页面</li>
        /// <li>PREVIEW_TEMPLATE：生成预览模板的嵌入页面</li>
        /// <li>PREVIEW_FLOW：生成预览合同文档的嵌入页面（支持移动端）</li>
        /// <li>PREVIEW_FLOW_DETAIL：生成预览合同详情的嵌入页面（仅支持PC端）</li>
        /// <li>PREVIEW_SEAL_LIST：生成预览印章列表的嵌入页面</li>
        /// <li>PREVIEW_SEAL_DETAIL：生成预览印章详情的嵌入页面</li>
        /// <li>EXTEND_SERVICE：生成扩展服务的嵌入页面</li>
        /// </ul>
        /// </summary>
        [JsonProperty("EmbedType")]
        public string EmbedType{ get; set; }

        /// <summary>
        /// WEB嵌入的业务资源ID
        /// 
        /// <ul>
        /// <li>当EmbedType取值MODIFY_TEMPLATE，PREVIEW_TEMPLATE时需要填写模板id作为BusinessId</li>
        /// <li>当EmbedType取值PREVIEW_FLOW，PREVIEW_FLOW_DETAIL时需要填写合同id作为BusinessId</li>
        /// <li>当EmbedType取值PREVIEW_SEAL_DETAIL需要填写印章id作为BusinessId</li>
        /// </ul>
        /// </summary>
        [JsonProperty("BusinessId")]
        public string BusinessId{ get; set; }

        /// <summary>
        /// 是否隐藏控件，只有预览模板时生效
        /// </summary>
        [JsonProperty("HiddenComponents")]
        public bool? HiddenComponents{ get; set; }

        /// <summary>
        /// 渠道操作者信息
        /// </summary>
        [JsonProperty("Operator")]
        [System.Obsolete]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 用户自定义参数
        /// <ul>
        /// <li>目前仅支持EmbedType=CREATE_TEMPLATE时传入</li>
        /// <li>指定后，创建，编辑，删除模板时，回调都会携带该userData</li>
        /// <li>支持的格式：json字符串的BASE64编码字符串</li>
        /// <li>示例：<ul>
        ///                  <li>json字符串：{"ComeFrom":"xxx"}，BASE64编码：eyJDb21lRnJvbSI6Inh4eCJ9</li>
        ///                  <li>eyJDb21lRnJvbSI6Inh4eCJ9，为符合要求的userData数据格式</li>
        /// </ul>
        /// </li>
        /// </ul>
        /// </summary>
        [JsonProperty("UserData")]
        public string UserData{ get; set; }

        /// <summary>
        /// 个性化参数，用于控制页面展示内容
        /// </summary>
        [JsonProperty("Option")]
        public EmbedUrlOption Option{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "EmbedType", this.EmbedType);
            this.SetParamSimple(map, prefix + "BusinessId", this.BusinessId);
            this.SetParamSimple(map, prefix + "HiddenComponents", this.HiddenComponents);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "UserData", this.UserData);
            this.SetParamObj(map, prefix + "Option.", this.Option);
        }
    }
}

