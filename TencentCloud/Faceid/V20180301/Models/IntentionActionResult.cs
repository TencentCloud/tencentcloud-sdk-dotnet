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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IntentionActionResult : AbstractModel
    {
        
        /// <summary>
        /// 意愿核身错误码：
        /// 0: "成功"       
        /// -1: "参数错误"    
        /// -2: "系统异常"    
        /// -101: "请保持人脸在框内"    
        /// -102: "检测到多张人脸"   
        /// -103: "人脸检测失败"   
        /// -104: "人脸检测不完整"   
        /// -105: "请勿遮挡眼睛"    
        /// -106: "请勿遮挡嘴巴"     
        /// -107: "请勿遮挡鼻子"     
        /// -201: "人脸比对相似度低"    
        /// -202: "人脸比对失败"    
        /// -301: "意愿核验不通过"   
        /// -800: "前端不兼容错误"    
        /// -801: "用户未授权摄像头和麦克风权限"   
        /// -802: "核验流程异常中断，请勿切屏或进行其他操作"   
        /// -803: "用户主动关闭链接/异常断开链接"   
        /// -998: "系统数据异常"   
        /// -999: "系统未知错误，请联系人工核实"   
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FinalResultDetailCode")]
        public long? FinalResultDetailCode{ get; set; }

        /// <summary>
        /// 意愿核身错误信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FinalResultMessage")]
        public string FinalResultMessage{ get; set; }

        /// <summary>
        /// 意愿核身结果详细数据，与每段点头确认过程一一对应
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Details")]
        public IntentionActionResultDetail[] Details{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FinalResultDetailCode", this.FinalResultDetailCode);
            this.SetParamSimple(map, prefix + "FinalResultMessage", this.FinalResultMessage);
            this.SetParamArrayObj(map, prefix + "Details.", this.Details);
        }
    }
}

