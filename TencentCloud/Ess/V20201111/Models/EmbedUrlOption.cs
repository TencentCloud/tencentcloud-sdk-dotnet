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

    public class EmbedUrlOption : AbstractModel
    {
        
        /// <summary>
        /// 合同详情预览，允许展示控件信息
        /// <br/>true：允许在合同详情页展示控件
        /// <br/>false：不允许在合同详情页展示控件
        /// <br/>默认false，合同详情页不展示控件
        /// </summary>
        [JsonProperty("ShowFlowDetailComponent")]
        public bool? ShowFlowDetailComponent{ get; set; }

        /// <summary>
        /// 模板预览，允许展示模板控件信息
        /// <br/>true：允许在模板预览页展示控件
        /// <br/>false：不允许在模板预览页展示控件
        /// <br/>默认false，模板预览页不展示控件
        /// </summary>
        [JsonProperty("ShowTemplateComponent")]
        public bool? ShowTemplateComponent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ShowFlowDetailComponent", this.ShowFlowDetailComponent);
            this.SetParamSimple(map, prefix + "ShowTemplateComponent", this.ShowTemplateComponent);
        }
    }
}

