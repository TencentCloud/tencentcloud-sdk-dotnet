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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DspaCOSDiscoveryTaskResult : AbstractModel
    {
        
        /// <summary>
        /// 扫描bucket结果ID
        /// </summary>
        [JsonProperty("BucketResultId")]
        public long? BucketResultId{ get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public long? TaskId{ get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 扫描任务最新一次扫描结果ID
        /// </summary>
        [JsonProperty("ResultId")]
        public long? ResultId{ get; set; }

        /// <summary>
        /// 数据源ID
        /// </summary>
        [JsonProperty("DataSourceId")]
        public string DataSourceId{ get; set; }

        /// <summary>
        /// 桶名称
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// 总文件数
        /// </summary>
        [JsonProperty("TotalFiles")]
        public long? TotalFiles{ get; set; }

        /// <summary>
        /// 被识别出的敏感数据数
        /// </summary>
        [JsonProperty("SensitiveDataNums")]
        public long? SensitiveDataNums{ get; set; }

        /// <summary>
        /// Bucket扫描的结束时间，格式如：2006-01-02 15:04:05
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 数据源名称
        /// </summary>
        [JsonProperty("DataSourceName")]
        public string DataSourceName{ get; set; }

        /// <summary>
        /// Bucket扫描状态，0待扫描 1扫描中 2扫描终止 3扫描成功 4扫描失败
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Bucket扫描结果错误信息
        /// </summary>
        [JsonProperty("ErrorInfo")]
        public string ErrorInfo{ get; set; }

        /// <summary>
        /// 资源所在地域
        /// </summary>
        [JsonProperty("ResourceRegion")]
        public string ResourceRegion{ get; set; }

        /// <summary>
        /// 是否超额
        /// </summary>
        [JsonProperty("OverSize")]
        public string OverSize{ get; set; }

        /// <summary>
        /// 任务实例id
        /// </summary>
        [JsonProperty("TaskInstanceId")]
        public string TaskInstanceId{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BucketResultId", this.BucketResultId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "ResultId", this.ResultId);
            this.SetParamSimple(map, prefix + "DataSourceId", this.DataSourceId);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "TotalFiles", this.TotalFiles);
            this.SetParamSimple(map, prefix + "SensitiveDataNums", this.SensitiveDataNums);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "DataSourceName", this.DataSourceName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrorInfo", this.ErrorInfo);
            this.SetParamSimple(map, prefix + "ResourceRegion", this.ResourceRegion);
            this.SetParamSimple(map, prefix + "OverSize", this.OverSize);
            this.SetParamSimple(map, prefix + "TaskInstanceId", this.TaskInstanceId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
        }
    }
}

