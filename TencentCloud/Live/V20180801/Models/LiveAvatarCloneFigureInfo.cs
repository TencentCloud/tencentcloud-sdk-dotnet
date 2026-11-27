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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LiveAvatarCloneFigureInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>克隆形象任务ID</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>场景模式</p><p>枚举值：</p><ul><li>PHOTO： 图生形象</li><li>GREEN_SCREEN： 绿幕形象</li><li>REAL_SHOT： 实景形象</li></ul>
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// <p>形象名称</p>
        /// </summary>
        [JsonProperty("FigureName")]
        public string FigureName{ get; set; }

        /// <summary>
        /// <p>性别：男或者女或者UNKNOWN</p>
        /// </summary>
        [JsonProperty("Gender")]
        public string Gender{ get; set; }

        /// <summary>
        /// <p>状态</p><p>枚举值：</p><ul><li>SUCCESS： 成功</li><li>FAILED： 失败</li><li>PROCESSING： 生成中</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>进度条</p>
        /// </summary>
        [JsonProperty("Progress")]
        public ulong? Progress{ get; set; }

        /// <summary>
        /// <p>克隆好的形象在系统的key</p>
        /// </summary>
        [JsonProperty("AvatarKey")]
        public string AvatarKey{ get; set; }

        /// <summary>
        /// <p>形象的图像</p>
        /// </summary>
        [JsonProperty("FigureImg")]
        public string FigureImg{ get; set; }

        /// <summary>
        /// <p>失败原因，成功时，该字段没值</p>
        /// </summary>
        [JsonProperty("FailReason")]
        public string FailReason{ get; set; }

        /// <summary>
        /// <p>训练视频</p>
        /// </summary>
        [JsonProperty("MaterialUrl")]
        public string MaterialUrl{ get; set; }

        /// <summary>
        /// <p>该克隆音色创建的时间</p><p>参数格式：YYYY-MM-DD</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间</p><p>参数格式：YYYY-MM</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>是否有续期</p>
        /// </summary>
        [JsonProperty("RenewStatus")]
        public string RenewStatus{ get; set; }

        /// <summary>
        /// <p>是否过期</p>
        /// </summary>
        [JsonProperty("IsExpired")]
        public bool? IsExpired{ get; set; }

        /// <summary>
        /// <p>有效期时间</p><p>参数格式：YYYY-MM</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// <p>是否循环播放(实景克隆形象能使用)</p>
        /// </summary>
        [JsonProperty("NeedPlayback")]
        public ulong? NeedPlayback{ get; set; }

        /// <summary>
        /// <p>训练幅度，0：表示只有有头部动；1表示头部和手势都有训练</p><p>单位：1</p>
        /// </summary>
        [JsonProperty("PhotoVersion")]
        public ulong? PhotoVersion{ get; set; }

        /// <summary>
        /// <p>待确认视频</p>
        /// </summary>
        [JsonProperty("ConfirmDemoUrls")]
        public string ConfirmDemoUrls{ get; set; }

        /// <summary>
        /// <p>形象克隆完成时间</p><p>参数格式：YYYY-MM</p>
        /// </summary>
        [JsonProperty("EstimatedCompleteTime")]
        public string EstimatedCompleteTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "SceneType", this.SceneType);
            this.SetParamSimple(map, prefix + "FigureName", this.FigureName);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "AvatarKey", this.AvatarKey);
            this.SetParamSimple(map, prefix + "FigureImg", this.FigureImg);
            this.SetParamSimple(map, prefix + "FailReason", this.FailReason);
            this.SetParamSimple(map, prefix + "MaterialUrl", this.MaterialUrl);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "RenewStatus", this.RenewStatus);
            this.SetParamSimple(map, prefix + "IsExpired", this.IsExpired);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "NeedPlayback", this.NeedPlayback);
            this.SetParamSimple(map, prefix + "PhotoVersion", this.PhotoVersion);
            this.SetParamSimple(map, prefix + "ConfirmDemoUrls", this.ConfirmDemoUrls);
            this.SetParamSimple(map, prefix + "EstimatedCompleteTime", this.EstimatedCompleteTime);
        }
    }
}

