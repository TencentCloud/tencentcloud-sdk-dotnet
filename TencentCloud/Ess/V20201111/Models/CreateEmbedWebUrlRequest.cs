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
        /// 操作者信息
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// WEB嵌入资源类型。
        /// <br/>CREATE_SEAL: 创建印章
        /// <br/>PREVIEW_SEAL_LIST：预览印章列表
        /// <br/>PREVIEW_SEAL_DETAIL：预览印章详情
        /// <br/>EXTEND_SERVICE：拓展服务
        /// <br/>PREVIEW_FLOW：预览合同
        /// <br/>PREVIEW_FLOW_DETAIL：查看合同详情
        /// </summary>
        [JsonProperty("EmbedType")]
        public string EmbedType{ get; set; }

        /// <summary>
        /// WEB嵌入的业务资源ID
        /// <br/>PREVIEW_SEAL_DETAIL，必填，取值为印章id
        /// </summary>
        [JsonProperty("BusinessId")]
        public string BusinessId{ get; set; }

        /// <summary>
        /// 代理相关应用信息，如集团主企业代子企业操作
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 抄送方信息
        /// </summary>
        [JsonProperty("Reviewer")]
        public ReviewerInfo Reviewer{ get; set; }

        /// <summary>
        /// 个性化参数
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

