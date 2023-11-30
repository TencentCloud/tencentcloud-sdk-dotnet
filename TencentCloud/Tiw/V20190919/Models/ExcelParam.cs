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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExcelParam : AbstractModel
    {
        
        /// <summary>
        /// 表格转码纸张（画布）大小，默认为0。
        /// 0 -- A4
        /// 1 -- A2 
        /// 2 -- A0
        /// 
        /// 注：当设置的值超出合法取值范围时，将采用默认值。
        /// </summary>
        [JsonProperty("PaperSize")]
        public long? PaperSize{ get; set; }

        /// <summary>
        /// 表格文件转换纸张方向，默认为0。
        /// 0 -- 代表垂直方向
        /// 非0 -- 代表水平方向
        /// </summary>
        [JsonProperty("PaperDirection")]
        public long? PaperDirection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PaperSize", this.PaperSize);
            this.SetParamSimple(map, prefix + "PaperDirection", this.PaperDirection);
        }
    }
}

