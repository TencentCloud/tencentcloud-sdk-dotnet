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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateEmbedWebUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行本接口操作的员工信息。
        /// <br/>注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// WEB嵌入资源类型。
        /// <br/>CREATE_SEAL: 生成创建印章的嵌入页面
        /// <br/>CREATE_TEMPLATE：生成创建模板的嵌入页面
        /// <br/>MODIFY_TEMPLATE：生成编辑模板的嵌入页面
        /// <br/>PREVIEW_TEMPLATE：生成预览模板的嵌入页面
        /// <br/>PREVIEW_SEAL_LIST：生成预览印章列表的嵌入页面
        /// <br/>PREVIEW_SEAL_DETAIL：生成预览印章详情的嵌入页面
        /// <br/>EXTEND_SERVICE：生成拓展服务的嵌入页面
        /// <br/>PREVIEW_FLOW：生成预览合同的嵌入页面
        /// <br/>PREVIEW_FLOW_DETAIL：生成查看合同详情的嵌入页面
        /// </summary>
        [JsonProperty("EmbedType")]
        public string EmbedType{ get; set; }

        /// <summary>
        /// WEB嵌入的业务资源ID
        /// <br/>PREVIEW_SEAL_DETAIL，必填，取值为印章id
        /// <br/>MODIFY_TEMPLATE，PREVIEW_TEMPLATE，必填，取值为模板id
        /// <br/>PREVIEW_FLOW，PREVIEW_FLOW_DETAIL，必填，取值为合同id
        /// </summary>
        [JsonProperty("BusinessId")]
        public string BusinessId{ get; set; }

        /// <summary>
        /// 代理企业和员工的信息。
        /// <br/>在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 抄送方信息
        /// </summary>
        [JsonProperty("Reviewer")]
        public ReviewerInfo Reviewer{ get; set; }

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
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "EmbedType", this.EmbedType);
            this.SetParamSimple(map, prefix + "BusinessId", this.BusinessId);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamObj(map, prefix + "Reviewer.", this.Reviewer);
            this.SetParamObj(map, prefix + "Option.", this.Option);
        }
    }
}

