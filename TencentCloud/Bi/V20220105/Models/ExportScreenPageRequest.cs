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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExportScreenPageRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 页面id
        /// </summary>
        [JsonProperty("PageId")]
        public string PageId{ get; set; }

        /// <summary>
        /// 画布类型。栅格画布：GRID；自由画布：FREE
        /// </summary>
        [JsonProperty("CanvasType")]
        public string CanvasType{ get; set; }

        /// <summary>
        /// 图片导出类型。base64；url（有效期：1天）
        /// </summary>
        [JsonProperty("PicType")]
        public string PicType{ get; set; }

        /// <summary>
        /// 组件Ids。为空时，导出整个页面
        /// </summary>
        [JsonProperty("WidgetIds")]
        public string[] WidgetIds{ get; set; }

        /// <summary>
        /// 是否是异步请求
        /// </summary>
        [JsonProperty("AsyncRequest")]
        public bool? AsyncRequest{ get; set; }

        /// <summary>
        /// 事务id
        /// </summary>
        [JsonProperty("TranId")]
        public string TranId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PageId", this.PageId);
            this.SetParamSimple(map, prefix + "CanvasType", this.CanvasType);
            this.SetParamSimple(map, prefix + "PicType", this.PicType);
            this.SetParamArraySimple(map, prefix + "WidgetIds.", this.WidgetIds);
            this.SetParamSimple(map, prefix + "AsyncRequest", this.AsyncRequest);
            this.SetParamSimple(map, prefix + "TranId", this.TranId);
        }
    }
}

