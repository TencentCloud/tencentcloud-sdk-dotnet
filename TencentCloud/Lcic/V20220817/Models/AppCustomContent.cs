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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AppCustomContent : AbstractModel
    {
        
        /// <summary>
        /// 场景参数，一个应用下可以设置多个不同场景。
        /// </summary>
        [JsonProperty("Scene")]
        public string Scene{ get; set; }

        /// <summary>
        /// logo地址，用于上课时展示的课堂或平台图标，支持开发商自定义业务品牌展示。
        /// </summary>
        [JsonProperty("LogoUrl")]
        public string LogoUrl{ get; set; }

        /// <summary>
        /// HomeUrl：主页地址，用于上课结束后课堂跳转，支持跳转到自己的业务系统。如果配置为空则下课后关闭课堂页面。
        /// </summary>
        [JsonProperty("HomeUrl")]
        public string HomeUrl{ get; set; }

        /// <summary>
        /// JsUrl ：自定义js。针对应用用于开发上自定义课堂界面、模块功能、监控操作，支持数据请求与响应处理。
        /// </summary>
        [JsonProperty("JsUrl")]
        public string JsUrl{ get; set; }

        /// <summary>
        /// Css : 自定义的css。针对应用用于支持课堂界面的、模块的UI渲染修改、皮肤配色修改、功能模块的隐藏和展示。
        /// </summary>
        [JsonProperty("CssUrl")]
        public string CssUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Scene", this.Scene);
            this.SetParamSimple(map, prefix + "LogoUrl", this.LogoUrl);
            this.SetParamSimple(map, prefix + "HomeUrl", this.HomeUrl);
            this.SetParamSimple(map, prefix + "JsUrl", this.JsUrl);
            this.SetParamSimple(map, prefix + "CssUrl", this.CssUrl);
        }
    }
}

