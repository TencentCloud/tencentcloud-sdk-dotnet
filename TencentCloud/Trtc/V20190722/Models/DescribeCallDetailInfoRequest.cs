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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCallDetailInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 通话 ID（唯一标识一次通话）： SdkAppId_RoomId（房间号）_ CreateTime（房间创建时间，unix时间戳，单位为s）例：1400xxxxxx_218695_1590065777。通过 DescribeRoomInfo（查询历史房间列表）接口获取（[查询历史房间列表](https://cloud.tencent.com/document/product/647/44050)）。
        /// </summary>
        [JsonProperty("CommId")]
        public string CommId{ get; set; }

        /// <summary>
        /// 查询开始时间，本地unix时间戳，单位为秒（如：1590065777），
        /// 注意：支持查询14天内的数据。
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// 查询结束时间，本地unix时间戳，单位为秒（如：1590065877）
        /// 注意：查询起止时间需小于1小时，超过则返回null，即与StartTime间隔时间不超过1小时。
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// 用户SdkAppId（如：1400xxxxxx）。
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// 需查询的用户数组，默认不填返回6个用户。
        /// </summary>
        [JsonProperty("UserIds")]
        public string[] UserIds{ get; set; }

        /// <summary>
        /// 需查询的指标，不填则只返回用户列表，填all则返回所有指标。
        /// appCpu：APP CPU使用率；
        /// sysCpu：系统 CPU使用率；
        /// aBit：上/下行音频码率；单位：bps
        /// aBlock：音频卡顿时长；单位：ms
        /// bigvBit：上/下行视频码率；单位：bps
        /// bigvCapFps：视频采集帧率；
        /// bigvEncFps：视频发送帧率；
        /// bigvDecFps：渲染帧率；
        /// bigvBlock：视频卡顿时长；单位：ms
        /// aLoss：上/下行音频丢包率；
        /// bigvLoss：上/下行视频丢包率；
        /// bigvWidth：上/下行分辨率宽；
        /// bigvHeight：上/下行分辨率高；
        /// aCapEnergy：音频采集能量；
        /// aPlayEnergy：音频播放能量；
        /// rtt：SDK到云端的往返延时；单位: ms
        /// </summary>
        [JsonProperty("DataType")]
        public string[] DataType{ get; set; }

        /// <summary>
        /// 当前页数，默认为0，
        /// 注意：PageNumber和PageSize 其中一个不填均默认返回6条数据。
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// 每页个数，默认为6，
        /// 范围：[1，100]
        /// 注意：DataType不为null，UserIds长度不能超过6，PageSize最大值不超过6；
        /// DataType 为null，UserIds长度不超过100，PageSize最大不超过100。
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CommId", this.CommId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamArraySimple(map, prefix + "UserIds.", this.UserIds);
            this.SetParamArraySimple(map, prefix + "DataType.", this.DataType);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
        }
    }
}

