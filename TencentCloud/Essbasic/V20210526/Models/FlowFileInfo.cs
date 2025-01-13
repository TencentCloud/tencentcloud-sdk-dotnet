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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FlowFileInfo : AbstractModel
    {
        
        /// <summary>
        /// 签署文件资源Id列表，目前仅支持单个文件
        /// </summary>
        [JsonProperty("FileIds")]
        public string[] FileIds{ get; set; }

        /// <summary>
        /// 签署流程名称，长度不超过200个字符
        /// </summary>
        [JsonProperty("FlowName")]
        public string FlowName{ get; set; }

        /// <summary>
        /// 签署流程签约方列表，最多不超过5个参与方
        /// </summary>
        [JsonProperty("FlowApprovers")]
        public FlowApproverInfo[] FlowApprovers{ get; set; }

        /// <summary>
        /// 签署流程截止时间，十位数时间戳，最大值为33162419560，即3020年
        /// </summary>
        [JsonProperty("Deadline")]
        public long? Deadline{ get; set; }

        /// <summary>
        /// 签署流程的描述，长度不超过1000个字符
        /// </summary>
        [JsonProperty("FlowDescription")]
        public string FlowDescription{ get; set; }

        /// <summary>
        /// 签署流程的类型，长度不超过255个字符
        /// </summary>
        [JsonProperty("FlowType")]
        public string FlowType{ get; set; }

        /// <summary>
        /// 已废弃，请使用【应用号配置】中的回调地址统一接收消息
        /// </summary>
        [JsonProperty("CallbackUrl")]
        [System.Obsolete]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 第三方应用的业务信息，最大长度1000个字符。
        /// </summary>
        [JsonProperty("CustomerData")]
        public string CustomerData{ get; set; }

        /// <summary>
        /// 合同签署顺序类型(无序签,顺序签)，默认为false，即有序签署
        /// </summary>
        [JsonProperty("Unordered")]
        public bool? Unordered{ get; set; }

        /// <summary>
        /// 签署文件中的发起方的填写控件，需要在发起的时候进行填充
        /// </summary>
        [JsonProperty("Components")]
        public Component[] Components{ get; set; }

        /// <summary>
        /// 合同显示的页卡模板，说明：只支持{合同名称}, {发起方企业}, {发起方姓名}, {签署方N企业}, {签署方N姓名}，且N不能超过签署人的数量，N从1开始
        /// </summary>
        [JsonProperty("CustomShowMap")]
        public string CustomShowMap{ get; set; }

        /// <summary>
        /// 本企业(发起方企业)是否需要签署审批
        /// </summary>
        [JsonProperty("NeedSignReview")]
        public bool? NeedSignReview{ get; set; }

        /// <summary>
        /// 在短信通知、填写、签署流程中，若标题、按钮、合同详情等地方存在“合同”字样时，可根据此配置指定文案，可选文案如下：  <ul><li> <b>0</b> :合同（默认值）</li> <li> <b>1</b> :文件</li> <li> <b>2</b> :协议</li></ul>效果如下:![FlowDisplayType](https://qcloudimg.tencent-cloud.cn/raw/e4a2c4d638717cc901d3dbd5137c9bbc.png)
        /// </summary>
        [JsonProperty("FlowDisplayType")]
        public long? FlowDisplayType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "FileIds.", this.FileIds);
            this.SetParamSimple(map, prefix + "FlowName", this.FlowName);
            this.SetParamArrayObj(map, prefix + "FlowApprovers.", this.FlowApprovers);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "FlowDescription", this.FlowDescription);
            this.SetParamSimple(map, prefix + "FlowType", this.FlowType);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "CustomerData", this.CustomerData);
            this.SetParamSimple(map, prefix + "Unordered", this.Unordered);
            this.SetParamArrayObj(map, prefix + "Components.", this.Components);
            this.SetParamSimple(map, prefix + "CustomShowMap", this.CustomShowMap);
            this.SetParamSimple(map, prefix + "NeedSignReview", this.NeedSignReview);
            this.SetParamSimple(map, prefix + "FlowDisplayType", this.FlowDisplayType);
        }
    }
}

