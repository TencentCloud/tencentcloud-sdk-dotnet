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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DropPageDetail : AbstractModel
    {
        
        /// <summary>
        /// 拦截页面的唯一Id。系统默认包含一个自带拦截页面，Id值为0。
        /// 该Id可通过创建拦截页面接口进行上传获取。如传入0，代表使用系统默认拦截页面
        /// </summary>
        [JsonProperty("PageId")]
        public long? PageId{ get; set; }

        /// <summary>
        /// 拦截页面的HTTP状态码。状态码范围是 100 - 600。
        /// </summary>
        [JsonProperty("StatusCode")]
        public long? StatusCode{ get; set; }

        /// <summary>
        /// 页面的元信息，文件名或url。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 页面的类型。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageId", this.PageId);
            this.SetParamSimple(map, prefix + "StatusCode", this.StatusCode);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

