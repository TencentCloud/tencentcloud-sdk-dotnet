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

namespace TencentCloud.Zj.V20190121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateMmsInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 商户证书
        /// </summary>
        [JsonProperty("License")]
        public string License{ get; set; }

        /// <summary>
        /// 样例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [JsonProperty("Sign")]
        public string Sign{ get; set; }

        /// <summary>
        /// 素材内容
        /// </summary>
        [JsonProperty("Contents")]
        public CreateMmsInstanceItem[] Contents{ get; set; }

        /// <summary>
        /// 样例中链接动态变量对应的链接，和占位符顺序一致
        /// </summary>
        [JsonProperty("Urls")]
        public string[] Urls{ get; set; }

        /// <summary>
        /// 机型列表
        /// </summary>
        [JsonProperty("PhoneType")]
        public ulong?[] PhoneType{ get; set; }

        /// <summary>
        /// 发送超短活动时用于展示人群包动态参数模板占位符序号或接口发送时变量占位符序号
        /// </summary>
        [JsonProperty("CommonParams")]
        public ulong?[] CommonParams{ get; set; }

        /// <summary>
        /// 发送超短活动时用于展示短连接模板占位符序号,仅用作超短活动
        /// </summary>
        [JsonProperty("UrlParams")]
        public ulong?[] UrlParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "License", this.License);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Sign", this.Sign);
            this.SetParamArrayObj(map, prefix + "Contents.", this.Contents);
            this.SetParamArraySimple(map, prefix + "Urls.", this.Urls);
            this.SetParamArraySimple(map, prefix + "PhoneType.", this.PhoneType);
            this.SetParamArraySimple(map, prefix + "CommonParams.", this.CommonParams);
            this.SetParamArraySimple(map, prefix + "UrlParams.", this.UrlParams);
        }
    }
}

