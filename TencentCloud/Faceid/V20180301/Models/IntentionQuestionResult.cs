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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IntentionQuestionResult : AbstractModel
    {
        
        /// <summary>
        /// 意愿核身错误码。
        /// - 取值范围：
        ///     0: "成功"       
        ///     -1: "参数错误"    
        ///     -2: "系统异常"    
        ///     -101: "请保持人脸在框内"    
        ///     -102: "检测到多张人脸"   
        ///     -103: "人脸检测失败"   
        ///     -104: "人脸检测不完整"   
        ///     -105: "请勿遮挡眼睛"    
        ///     -106: "请勿遮挡嘴巴"     
        ///     -107: "请勿遮挡鼻子"     
        ///     -201: "人脸比对相似度低"    
        ///     -202: "人脸比对失败"    
        ///     -301: "意愿核验不通过"       
        ///     -302: "用户回答阶段未检测到张嘴动作"  
        ///     -800: "前端不兼容错误"    
        ///     -801: "用户未授权摄像头和麦克风权限"   
        ///     -802: "核验流程异常中断，请勿切屏或进行其他操作"   
        ///     -803: "用户主动关闭链接/异常断开链接"   
        ///     -804: "用户当前网络不稳定，请重试"
        ///     -998: "系统数据异常"   
        ///     -999: "系统未知错误，请联系人工核实"   
        /// - 若在人脸核身过程失败、未进入意愿确认过程，则该参数返回为空，请参考人脸核身错误码结果（DetectInfoText.ErrCode)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FinalResultDetailCode")]
        public long? FinalResultDetailCode{ get; set; }

        /// <summary>
        /// 意愿核身错误信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FinalResultMessage")]
        public string FinalResultMessage{ get; set; }

        /// <summary>
        /// 视频base64。
        /// - 其中包含全程问题和回答音频，mp4格式。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Video")]
        public string Video{ get; set; }

        /// <summary>
        /// 屏幕截图base64列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScreenShot")]
        public string[] ScreenShot{ get; set; }

        /// <summary>
        /// 和答案匹配结果列表。
        /// - 取值范围（0：成功；-1：不匹配）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResultCode")]
        public string[] ResultCode{ get; set; }

        /// <summary>
        /// 回答问题语音识别结果列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AsrResult")]
        public string[] AsrResult{ get; set; }

        /// <summary>
        /// 答案录音音频。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Audios")]
        public string[] Audios{ get; set; }

        /// <summary>
        /// 意愿核身最终结果。
        /// - 取值范围：
        /// 0：认证通过。
        /// -1：认证未通过。
        /// -2：浏览器内核不兼容，无法进行意愿校验。
        /// - 建议使用“FinalResultDetailCode”参数获取详细的错误码信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FinalResultCode")]
        public string FinalResultCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FinalResultDetailCode", this.FinalResultDetailCode);
            this.SetParamSimple(map, prefix + "FinalResultMessage", this.FinalResultMessage);
            this.SetParamSimple(map, prefix + "Video", this.Video);
            this.SetParamArraySimple(map, prefix + "ScreenShot.", this.ScreenShot);
            this.SetParamArraySimple(map, prefix + "ResultCode.", this.ResultCode);
            this.SetParamArraySimple(map, prefix + "AsrResult.", this.AsrResult);
            this.SetParamArraySimple(map, prefix + "Audios.", this.Audios);
            this.SetParamSimple(map, prefix + "FinalResultCode", this.FinalResultCode);
        }
    }
}

