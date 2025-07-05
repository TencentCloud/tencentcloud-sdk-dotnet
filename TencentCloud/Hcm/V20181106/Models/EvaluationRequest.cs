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

namespace TencentCloud.Hcm.V20181106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EvaluationRequest : AbstractModel
    {
        
        /// <summary>
        /// 图片唯一标识，一张图片一个SessionId；
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 图片数据，需要使用base64对图片的二进制数据进行编码，与url参数二者填一即可；
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// 业务应用ID，与账号应用APPID无关，是用来方便客户管理服务的参数，新的 HcmAppid 可以在[控制台](https://console.cloud.tencent.com/hcm)【应用管理】下新建。
        /// </summary>
        [JsonProperty("HcmAppid")]
        public string HcmAppid{ get; set; }

        /// <summary>
        /// 图片url，与Image参数二者填一即可；
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 横屏拍摄开关，若开启则支持传输横屏拍摄的图片；
        /// </summary>
        [JsonProperty("SupportHorizontalImage")]
        public bool? SupportHorizontalImage{ get; set; }

        /// <summary>
        /// 拒绝非速算图（如风景图、人物图）开关，若开启，则遇到非速算图会快速返回拒绝的结果，但极端情况下可能会影响评估结果（比如算式截图贴到风景画里可能被判为非速算图直接返回了）。
        /// </summary>
        [JsonProperty("RejectNonArithmeticImage")]
        public bool? RejectNonArithmeticImage{ get; set; }

        /// <summary>
        /// 异步模式标识，0：同步模式，1：异步模式。默认为同步模式
        /// </summary>
        [JsonProperty("IsAsync")]
        [System.Obsolete]
        public long? IsAsync{ get; set; }

        /// <summary>
        /// 是否展开耦合算式中的竖式计算
        /// </summary>
        [JsonProperty("EnableDispRelatedVertical")]
        public bool? EnableDispRelatedVertical{ get; set; }

        /// <summary>
        /// 是否展示竖式算式的中间结果和格式控制字符
        /// </summary>
        [JsonProperty("EnableDispMidresult")]
        public bool? EnableDispMidresult{ get; set; }

        /// <summary>
        /// 是否开启pdf识别，默认开启
        /// </summary>
        [JsonProperty("EnablePdfRecognize")]
        public bool? EnablePdfRecognize{ get; set; }

        /// <summary>
        /// pdf页码，从0开始，默认为0
        /// </summary>
        [JsonProperty("PdfPageIndex")]
        public long? PdfPageIndex{ get; set; }

        /// <summary>
        /// 是否返回LaTex，默认为0返回普通格式，设置成1返回LaTex格式
        /// </summary>
        [JsonProperty("LaTex")]
        public long? LaTex{ get; set; }

        /// <summary>
        /// 用于选择是否拒绝模糊题 目。打开则丢弃模糊题目， 不进行后续的判题返回结 果。
        /// </summary>
        [JsonProperty("RejectVagueArithmetic")]
        public bool? RejectVagueArithmetic{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "HcmAppid", this.HcmAppid);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "SupportHorizontalImage", this.SupportHorizontalImage);
            this.SetParamSimple(map, prefix + "RejectNonArithmeticImage", this.RejectNonArithmeticImage);
            this.SetParamSimple(map, prefix + "IsAsync", this.IsAsync);
            this.SetParamSimple(map, prefix + "EnableDispRelatedVertical", this.EnableDispRelatedVertical);
            this.SetParamSimple(map, prefix + "EnableDispMidresult", this.EnableDispMidresult);
            this.SetParamSimple(map, prefix + "EnablePdfRecognize", this.EnablePdfRecognize);
            this.SetParamSimple(map, prefix + "PdfPageIndex", this.PdfPageIndex);
            this.SetParamSimple(map, prefix + "LaTex", this.LaTex);
            this.SetParamSimple(map, prefix + "RejectVagueArithmetic", this.RejectVagueArithmetic);
        }
    }
}

