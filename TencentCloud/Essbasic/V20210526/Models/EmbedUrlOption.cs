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

    public class EmbedUrlOption : AbstractModel
    {
        
        /// <summary>
        /// 合同详情预览，允许展示控件信息
        /// <ul>
        /// <li><b>true</b>：允许在合同详情页展示控件</li>
        /// <li><b>false</b>：（默认）不允许在合同详情页展示控件</li>
        /// </ul>
        /// </summary>
        [JsonProperty("ShowFlowDetailComponent")]
        public bool? ShowFlowDetailComponent{ get; set; }

        /// <summary>
        /// 模板预览，允许展示模板控件信息
        /// <ul><li> <b>true</b> :允许在模板预览页展示控件</li>
        /// <li> <b>false</b> :（默认）不允许在模板预览页展示控件</li></ul>
        /// </summary>
        [JsonProperty("ShowTemplateComponent")]
        public bool? ShowTemplateComponent{ get; set; }

        /// <summary>
        /// 跳过上传文件，默认为false(展示上传文件页）![image](https://qcloudimg.tencent-cloud.cn/raw/8ca33745cf772e79831dbe5a70e82400.png)
        /// - false: 展示上传文件页
        /// - true: 不展示上传文件页
        ///  
        /// 
        /// 注意: 此参数仅针对**EmbedType=CREATE_TEMPLATE(创建模板)有效**，
        /// </summary>
        [JsonProperty("SkipUploadFile")]
        public string SkipUploadFile{ get; set; }

        /// <summary>
        /// 是否禁止编辑（展示）水印控件属性
        /// <ul><li>（默认） false -否</li> <li> true - 禁止编辑</li></ul>
        /// </summary>
        [JsonProperty("ForbidEditWatermark")]
        public bool? ForbidEditWatermark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ShowFlowDetailComponent", this.ShowFlowDetailComponent);
            this.SetParamSimple(map, prefix + "ShowTemplateComponent", this.ShowTemplateComponent);
            this.SetParamSimple(map, prefix + "SkipUploadFile", this.SkipUploadFile);
            this.SetParamSimple(map, prefix + "ForbidEditWatermark", this.ForbidEditWatermark);
        }
    }
}

