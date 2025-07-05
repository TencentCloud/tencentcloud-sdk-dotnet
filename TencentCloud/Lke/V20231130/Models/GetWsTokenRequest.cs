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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetWsTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// 接入类型， 5-API 访客
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        ///   应用AppKey </br>   获取方式:</br>   1、应用发布后在应用页面[发布管理]-[调用信息]-[API管理]处获取</br>   2、参考 https://cloud.tencent.com/document/product/1759/109469 第二项
        /// </summary>
        [JsonProperty("BotAppKey")]
        public string BotAppKey{ get; set; }

        /// <summary>
        /// 访客ID（外部输入，建议唯一，标识当前接入会话的用户）
        /// 长度限制： string(64)
        /// </summary>
        [JsonProperty("VisitorBizId")]
        public string VisitorBizId{ get; set; }

        /// <summary>
        /// 知识标签，用于知识库中知识的检索过滤。该字段即将下线，请使用对话端接口中的 custom_variables 字段替代该字段。
        /// </summary>
        [JsonProperty("VisitorLabels")]
        public GetWsTokenReq_Label[] VisitorLabels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "BotAppKey", this.BotAppKey);
            this.SetParamSimple(map, prefix + "VisitorBizId", this.VisitorBizId);
            this.SetParamArrayObj(map, prefix + "VisitorLabels.", this.VisitorLabels);
        }
    }
}

