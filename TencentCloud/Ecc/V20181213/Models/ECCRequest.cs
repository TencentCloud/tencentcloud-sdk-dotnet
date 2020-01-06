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

namespace TencentCloud.Ecc.V20181213.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ECCRequest : AbstractModel
    {
        
        /// <summary>
        /// 作文文本，必填
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 作文题目，可选参数
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 年级标准， 默认以cet4为标准，取值与意义如下：elementary 小学，grade7 grade8 grade9分别对应初一，初二，初三。 grade10 grade11 grade12 分别对应高一，高二，高三，以及cet4和cet6 分别表示 英语4级和6级。
        /// </summary>
        [JsonProperty("Grade")]
        public string Grade{ get; set; }

        /// <summary>
        /// 作文提纲，可选参数，作文的写作要求。
        /// </summary>
        [JsonProperty("Requirement")]
        public string Requirement{ get; set; }

        /// <summary>
        /// 范文标题，可选参数，本接口可以依据提供的范文对作文进行评分。
        /// </summary>
        [JsonProperty("ModelTitle")]
        public string ModelTitle{ get; set; }

        /// <summary>
        /// 范文内容，可选参数，同上，范文的正文部分。
        /// </summary>
        [JsonProperty("ModelContent")]
        public string ModelContent{ get; set; }

        /// <summary>
        /// 业务应用ID，与账号应用APPID无关，是用来方便客户管理服务的参数（暂时无需传入）。
        /// </summary>
        [JsonProperty("EccAppid")]
        public string EccAppid{ get; set; }

        /// <summary>
        /// 异步模式标识，0：同步模式，1：异步模式，默认为同步模式
        /// </summary>
        [JsonProperty("IsAsync")]
        public long? IsAsync{ get; set; }

        /// <summary>
        /// 图像识别唯一标识，一次识别一个 SessionId。当传入此前识别接口使用过的 SessionId，则本次批改按图像批改价格收费；如使用了识别接口且本次没有传入 SessionId，则需要加取文本批改的费用；如果直接使用文本批改接口，则只收取文本批改的费用
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Grade", this.Grade);
            this.SetParamSimple(map, prefix + "Requirement", this.Requirement);
            this.SetParamSimple(map, prefix + "ModelTitle", this.ModelTitle);
            this.SetParamSimple(map, prefix + "ModelContent", this.ModelContent);
            this.SetParamSimple(map, prefix + "EccAppid", this.EccAppid);
            this.SetParamSimple(map, prefix + "IsAsync", this.IsAsync);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
        }
    }
}

