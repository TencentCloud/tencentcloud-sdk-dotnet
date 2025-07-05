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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SignComponentConfig : AbstractModel
    {
        
        /// <summary>
        /// 签署控件默认属性配置，是否默认展示签署日期， 在页面中可以进行修改。
        /// 
        /// - false 展示签署日期（默认）
        /// - true 不展示签署日期 
        /// ![image](https://qcloudimg.tencent-cloud.cn/raw/448514412e2f69f6129425beda4ff568.png)。
        /// </summary>
        [JsonProperty("HideDate")]
        public bool? HideDate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HideDate", this.HideDate);
        }
    }
}

