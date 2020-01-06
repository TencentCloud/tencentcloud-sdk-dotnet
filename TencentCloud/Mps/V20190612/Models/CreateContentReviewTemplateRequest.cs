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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateContentReviewTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 内容审核模板名称，长度限制：64 个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 内容审核模板描述信息，长度限制：256 个字符。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 鉴黄控制参数。
        /// </summary>
        [JsonProperty("PornConfigure")]
        public PornConfigureInfo PornConfigure{ get; set; }

        /// <summary>
        /// 鉴恐控制参数。
        /// </summary>
        [JsonProperty("TerrorismConfigure")]
        public TerrorismConfigureInfo TerrorismConfigure{ get; set; }

        /// <summary>
        /// 鉴政控制参数。
        /// </summary>
        [JsonProperty("PoliticalConfigure")]
        public PoliticalConfigureInfo PoliticalConfigure{ get; set; }

        /// <summary>
        /// 用户自定义内容审核控制参数。
        /// </summary>
        [JsonProperty("UserDefineConfigure")]
        public UserDefineConfigureInfo UserDefineConfigure{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamObj(map, prefix + "PornConfigure.", this.PornConfigure);
            this.SetParamObj(map, prefix + "TerrorismConfigure.", this.TerrorismConfigure);
            this.SetParamObj(map, prefix + "PoliticalConfigure.", this.PoliticalConfigure);
            this.SetParamObj(map, prefix + "UserDefineConfigure.", this.UserDefineConfigure);
        }
    }
}

