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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaxPayment : AbstractModel
    {
        
        /// <summary>
        /// 发票名称
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 识别出的字段名称(关键字)，支持以下字段：
        /// 税号 、纳税人识别号 、纳税人名称 、金额合计大写 、金额合计小写 、填发日期 、税务机关 、填票人。
        /// 示例值：纳税人识别号
        /// </summary>
        [JsonProperty("Content")]
        public OtherInvoiceItem[] Content{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamArrayObj(map, prefix + "Content.", this.Content);
        }
    }
}

