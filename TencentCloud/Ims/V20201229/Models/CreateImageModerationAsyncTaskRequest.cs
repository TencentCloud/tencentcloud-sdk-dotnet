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

namespace TencentCloud.Ims.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateImageModerationAsyncTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>接收审核信息回调地址，审核过程中产生的所有结果发送至此地址。</p>
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// <p>接口使用的识别策略编号，<strong>该策略编号在控制台上获取</strong>，获取方式请参考快速入门：</p><ul><li>标准内容安全：https://cloud.tencent.com/document/product/1124/135196</li><li>AI 生成识别：https://cloud.tencent.com/document/product/1124/135204</li></ul>
        /// </summary>
        [JsonProperty("BizType")]
        public string BizType{ get; set; }

        /// <summary>
        /// <p>该字段表示您为待检测图片分配的数据 ID，作用是方便您对数据进行标识和管理。<br>取值：由英文字母（大小写均可）、数字及四个特殊符号（_，-，@，#）组成，<strong>长度不超过64个字符</strong>。</p>
        /// </summary>
        [JsonProperty("DataId")]
        public string DataId{ get; set; }

        /// <summary>
        /// <p>待检测图片的 Base64 编码， <strong>该字段与FileUrl必须选择输入其中一个</strong>。</p>
        /// </summary>
        [JsonProperty("FileContent")]
        public string FileContent{ get; set; }

        /// <summary>
        /// <p>待检测图片的访问链接，<strong>该字段与FileContent必须选择输入其中一个</strong>。</p>
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }

        /// <summary>
        /// <p>用于 GIF 检测，表示截帧频率（每隔多少帧抽取一帧进行检测）。<br>建议与  MaxFrames 字段组合使用，例如  Interval=3、 MaxFrames=4，表示每 3 帧抽取 1 帧，最多检测 4 帧。默认值为 0，表示仅检测 GIF 第一帧</p>
        /// </summary>
        [JsonProperty("Interval")]
        public long? Interval{ get; set; }

        /// <summary>
        /// <p>用于 GIF 检测，指定最大截帧数量，上限为 5 帧（暂不支持上调至更高值）。<br>建议与  Interval 字段配合使用：例如  Interval=3、 MaxFrames=4，表示每 3 帧抽取 1 帧，最多检测 4 帧。默认值为 1，即仅检测 GIF 首帧。</p>
        /// </summary>
        [JsonProperty("MaxFrames")]
        public long? MaxFrames{ get; set; }

        /// <summary>
        /// <p>该字段标识用户信息，传入后可增强甄别有违规风险的发布者账号。</p>
        /// </summary>
        [JsonProperty("User")]
        public User User{ get; set; }

        /// <summary>
        /// <p>该字段标识设备信息，传入后可增强甄别有违规风险的发布者设备。</p>
        /// </summary>
        [JsonProperty("Device")]
        public Device Device{ get; set; }

        /// <summary>
        /// <p>服务类型，可为空，默认为 IMAGE。</p><p>枚举值：</p><ul><li>IMAGE： 标准内容安全</li><li>IMAGE_AIGC： AI 生成识别</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>审核 Agent 专用：待审核图片的访问链接 ，一次请求最多支持传入 4 张。</p>
        /// </summary>
        [JsonProperty("FileUrlList")]
        public string[] FileUrlList{ get; set; }

        /// <summary>
        /// <p>审核 Agent 专用：待审文本内容，需使用 UTF-8 编码并以 Base64 格式传入，字数上限 5000 字。</p>
        /// </summary>
        [JsonProperty("TextContent")]
        public string TextContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "DataId", this.DataId);
            this.SetParamSimple(map, prefix + "FileContent", this.FileContent);
            this.SetParamSimple(map, prefix + "FileUrl", this.FileUrl);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "MaxFrames", this.MaxFrames);
            this.SetParamObj(map, prefix + "User.", this.User);
            this.SetParamObj(map, prefix + "Device.", this.Device);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "FileUrlList.", this.FileUrlList);
            this.SetParamSimple(map, prefix + "TextContent", this.TextContent);
        }
    }
}

