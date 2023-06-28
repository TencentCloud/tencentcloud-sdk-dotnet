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
        /// 渠道应用相关信息。 此接口Agent.ProxyOrganizationOpenId、Agent. ProxyOperator.OpenId、Agent.AppId 和 Agent.ProxyAppId 必填。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// WEB嵌入资源类型。
        /// CREATE_SEAL: 创建印章
        /// CREATE_TEMPLATE：创建模版
        /// MODIFY_TEMPLATE：修改模版
        /// PREVIEW_TEMPLATE：预览模版
        /// PREVIEW_FLOW：预览合同文档
        /// PREVIEW_FLOW_DETAIL：预览合同详情
        /// PREVIEW_SEAL_LIST：预览印章列表
        /// PREVIEW_SEAL_DETAIL：预览印章详情
        /// EXTEND_SERVICE：扩展服务
        /// </summary>
        [JsonProperty("EmbedType")]
        public string EmbedType{ get; set; }

        /// <summary>
        /// WEB嵌入的业务资源ID
        /// EmbedType取值MODIFY_TEMPLATE，PREVIEW_TEMPLATE时必填，取值为模版id
        /// PREVIEW_FLOW，PREVIEW_FLOW_DETAIL时必填，取值为合同id
        /// PREVIEW_SEAL_DETAIL，必填，取值为印章id
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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "EmbedType", this.EmbedType);
            this.SetParamSimple(map, prefix + "BusinessId", this.BusinessId);
            this.SetParamSimple(map, prefix + "HiddenComponents", this.HiddenComponents);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
        }
    }
}

