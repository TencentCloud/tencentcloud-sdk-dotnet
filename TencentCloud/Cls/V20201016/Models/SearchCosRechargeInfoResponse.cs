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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchCosRechargeInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 匹配到的存储桶下的某个文件的前几行数据
        /// </summary>
        [JsonProperty("Data")]
        public string[] Data{ get; set; }

        /// <summary>
        /// 匹配到的存储桶下的文件个数
        /// </summary>
        [JsonProperty("Sum")]
        public ulong? Sum{ get; set; }

        /// <summary>
        /// 当前预览文件路径
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// 预览获取数据失败原因
        /// </summary>
        [JsonProperty("Msg")]
        public string Msg{ get; set; }

        /// <summary>
        /// 状态。
        /// - 0：成功
        /// - 10000：参数错误，请确认参数
        /// - 10001：授权失败，请确认授权
        /// - 10002：获取文件列表失败，请稍后再试。若无法解决，请咨询 [在线支持](https://cloud.tencent.com/online-service) 或 [提交工单](https://console.cloud.tencent.com/workorder/category?level1_id=83&level2_id=469&source=14&data_title=%E6%97%A5%E5%BF%97%E6%9C%8D%E5%8A%A1&step=1) 处理。
        /// - 10003：桶内无相应前缀文件，请使用正确的桶、文件前缀和压缩方式
        /// - 10004：文件下载失败，请稍后再试。若无法解决，请咨询 [在线支持](https://cloud.tencent.com/online-service) 或 [提交工单](https://console.cloud.tencent.com/workorder/category?level1_id=83&level2_id=469&source=14&data_title=%E6%97%A5%E5%BF%97%E6%9C%8D%E5%8A%A1&step=1) 处理。
        /// - 10005：文件解压缩失败，请选择正确的压缩方式然后再试
        /// - 10006：读取文件内容失败，请确认文件可读
        /// - 10007：文件预览失败，请稍后再试。若无法解决，请咨询 [在线支持](https://cloud.tencent.com/online-service) 或 [提交工单](https://console.cloud.tencent.com/workorder/category?level1_id=83&level2_id=469&source=14&data_title=%E6%97%A5%E5%BF%97%E6%9C%8D%E5%8A%A1&step=1) 处理。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Data.", this.Data);
            this.SetParamSimple(map, prefix + "Sum", this.Sum);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "Msg", this.Msg);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

