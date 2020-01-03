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

    public class MixedInvoiceItem : AbstractModel
    {
        
        /// <summary>
        /// 识别结果。
        /// OK：表示识别成功；FailedOperation.UnsupportedInvioce：表示不支持识别；
        /// FailedOperation.UnKnowError：表示识别失败；
        /// 其它错误码见各个票据接口的定义。
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// 识别出的图片所属的票据类型。
        /// -1：未知类型
        /// 0：出租车发票
        /// 1：定额发票
        /// 2：火车票
        /// 3：增值税发票
        /// 5：机票行程单
        /// 8：通用机打发票
        /// 9：汽车票
        /// 10：轮船票
        /// 11：增值税发票（卷票 ）
        /// 12：购车发票
        /// 13：过路过桥费发票
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 识别出的图片在混贴票据图片中的位置信息。
        /// </summary>
        [JsonProperty("Rect")]
        public Rect Rect{ get; set; }

        /// <summary>
        /// 识别出的图片在混贴票据图片中的旋转角度。
        /// </summary>
        [JsonProperty("Angle")]
        public float? Angle{ get; set; }

        /// <summary>
        /// 识别到的内容。
        /// </summary>
        [JsonProperty("SingleInvoiceInfos")]
        public SingleInvoiceInfo[] SingleInvoiceInfos{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "Rect.", this.Rect);
            this.SetParamSimple(map, prefix + "Angle", this.Angle);
            this.SetParamArrayObj(map, prefix + "SingleInvoiceInfos.", this.SingleInvoiceInfos);
        }
    }
}

