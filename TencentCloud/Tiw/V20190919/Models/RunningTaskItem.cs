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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RunningTaskItem : AbstractModel
    {
        
        /// <summary>
        /// 应用SdkAppID
        /// </summary>
        [JsonProperty("SdkAppID")]
        public long? SdkAppID{ get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskID")]
        public string TaskID{ get; set; }

        /// <summary>
        /// 任务类型
        /// - TranscodeH5: 动态转码任务，文档转HTML5页面
        /// - TranscodeJPG: 静态转码任务，文档转图片
        /// - WhiteboardPush: 白板推流任务
        /// - OnlineRecord: 实时录制任务
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 任务创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 任务取消时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CancelTime")]
        public string CancelTime{ get; set; }

        /// <summary>
        /// 任务状态
        /// - QUEUED: 任务正在排队等待执行中
        /// - PROCESSING: 任务正在执行中 
        /// - FINISHED: 任务已完成
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 任务当前进度
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }

        /// <summary>
        /// 转码任务中转码文件的原始URL
        /// 此参数只有任务类型为TranscodeH5、TranscodeJPG类型时才会有有效值。其他任务类型为空字符串。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileURL")]
        public string FileURL{ get; set; }

        /// <summary>
        /// 房间号
        /// 
        /// 当任务类型为TranscodeH5、TranscodeJPG时，房间号为0。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RoomID")]
        public long? RoomID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppID", this.SdkAppID);
            this.SetParamSimple(map, prefix + "TaskID", this.TaskID);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "CancelTime", this.CancelTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "FileURL", this.FileURL);
            this.SetParamSimple(map, prefix + "RoomID", this.RoomID);
        }
    }
}

