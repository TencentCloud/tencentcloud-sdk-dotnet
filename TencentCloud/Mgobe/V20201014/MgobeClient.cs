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

namespace TencentCloud.Mgobe.V20201014
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Mgobe.V20201014.Models;

   public class MgobeClient : AbstractClient{

       private const string endpoint = "mgobe.tencentcloudapi.com";
       private const string version = "2020-10-14";
       private const string sdkVersion = "SDK_NET_3.0.1109";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MgobeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MgobeClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 此接口无法使用，游戏联机对战引擎MGOBE已于6.1正式下架，感谢您的支持
        /// 
        /// 修改房间玩家自定义属性
        /// </summary>
        /// <param name="req"><see cref="ChangeRoomPlayerProfileRequest"/></param>
        /// <returns><see cref="ChangeRoomPlayerProfileResponse"/></returns>
        public Task<ChangeRoomPlayerProfileResponse> ChangeRoomPlayerProfile(ChangeRoomPlayerProfileRequest req)
        {
            return InternalRequestAsync<ChangeRoomPlayerProfileResponse>(req, "ChangeRoomPlayerProfile");
        }

        /// <summary>
        /// 此接口无法使用，游戏联机对战引擎MGOBE已于6.1正式下架，感谢您的支持
        /// 
        /// 修改房间玩家自定义属性
        /// </summary>
        /// <param name="req"><see cref="ChangeRoomPlayerProfileRequest"/></param>
        /// <returns><see cref="ChangeRoomPlayerProfileResponse"/></returns>
        public ChangeRoomPlayerProfileResponse ChangeRoomPlayerProfileSync(ChangeRoomPlayerProfileRequest req)
        {
            return InternalRequestAsync<ChangeRoomPlayerProfileResponse>(req, "ChangeRoomPlayerProfile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏联机对战引擎MGOBE已于6.1正式下架，感谢您的支持
        /// 
        /// 修改玩家自定义状态
        /// </summary>
        /// <param name="req"><see cref="ChangeRoomPlayerStatusRequest"/></param>
        /// <returns><see cref="ChangeRoomPlayerStatusResponse"/></returns>
        public Task<ChangeRoomPlayerStatusResponse> ChangeRoomPlayerStatus(ChangeRoomPlayerStatusRequest req)
        {
            return InternalRequestAsync<ChangeRoomPlayerStatusResponse>(req, "ChangeRoomPlayerStatus");
        }

        /// <summary>
        /// 此接口无法使用，游戏联机对战引擎MGOBE已于6.1正式下架，感谢您的支持
        /// 
        /// 修改玩家自定义状态
        /// </summary>
        /// <param name="req"><see cref="ChangeRoomPlayerStatusRequest"/></param>
        /// <returns><see cref="ChangeRoomPlayerStatusResponse"/></returns>
        public ChangeRoomPlayerStatusResponse ChangeRoomPlayerStatusSync(ChangeRoomPlayerStatusRequest req)
        {
            return InternalRequestAsync<ChangeRoomPlayerStatusResponse>(req, "ChangeRoomPlayerStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏联机对战引擎MGOBE已于6.1正式下架，感谢您的支持
        /// 
        /// 该接口用于查询玩家信息。支持两种用法，当OpenId不传的时候，PlayerId必传，传入PlayerId可以查询当前PlayerId的玩家信息，当OpenId传入的时候，PlayerId可不传，按照OpenId查询玩家信息。
        /// </summary>
        /// <param name="req"><see cref="DescribePlayerRequest"/></param>
        /// <returns><see cref="DescribePlayerResponse"/></returns>
        public Task<DescribePlayerResponse> DescribePlayer(DescribePlayerRequest req)
        {
            return InternalRequestAsync<DescribePlayerResponse>(req, "DescribePlayer");
        }

        /// <summary>
        /// 此接口无法使用，游戏联机对战引擎MGOBE已于6.1正式下架，感谢您的支持
        /// 
        /// 该接口用于查询玩家信息。支持两种用法，当OpenId不传的时候，PlayerId必传，传入PlayerId可以查询当前PlayerId的玩家信息，当OpenId传入的时候，PlayerId可不传，按照OpenId查询玩家信息。
        /// </summary>
        /// <param name="req"><see cref="DescribePlayerRequest"/></param>
        /// <returns><see cref="DescribePlayerResponse"/></returns>
        public DescribePlayerResponse DescribePlayerSync(DescribePlayerRequest req)
        {
            return InternalRequestAsync<DescribePlayerResponse>(req, "DescribePlayer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏联机对战引擎MGOBE已于6.1正式下架，感谢您的支持
        /// 
        /// 该接口用于查询房间信息。支持两种用法，当房间Id不传的时候，玩家Id必传，传入玩家Id可以查询当前玩家所在的房间信息，当房间Id传入的时候，玩家Id可不传，按照房间Id查询房间信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomRequest"/></param>
        /// <returns><see cref="DescribeRoomResponse"/></returns>
        public Task<DescribeRoomResponse> DescribeRoom(DescribeRoomRequest req)
        {
            return InternalRequestAsync<DescribeRoomResponse>(req, "DescribeRoom");
        }

        /// <summary>
        /// 此接口无法使用，游戏联机对战引擎MGOBE已于6.1正式下架，感谢您的支持
        /// 
        /// 该接口用于查询房间信息。支持两种用法，当房间Id不传的时候，玩家Id必传，传入玩家Id可以查询当前玩家所在的房间信息，当房间Id传入的时候，玩家Id可不传，按照房间Id查询房间信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomRequest"/></param>
        /// <returns><see cref="DescribeRoomResponse"/></returns>
        public DescribeRoomResponse DescribeRoomSync(DescribeRoomRequest req)
        {
            return InternalRequestAsync<DescribeRoomResponse>(req, "DescribeRoom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏联机对战引擎MGOBE已于6.1正式下架，感谢您的支持
        /// 
        /// 通过game_id、room_id解散房间
        /// </summary>
        /// <param name="req"><see cref="DismissRoomRequest"/></param>
        /// <returns><see cref="DismissRoomResponse"/></returns>
        public Task<DismissRoomResponse> DismissRoom(DismissRoomRequest req)
        {
            return InternalRequestAsync<DismissRoomResponse>(req, "DismissRoom");
        }

        /// <summary>
        /// 此接口无法使用，游戏联机对战引擎MGOBE已于6.1正式下架，感谢您的支持
        /// 
        /// 通过game_id、room_id解散房间
        /// </summary>
        /// <param name="req"><see cref="DismissRoomRequest"/></param>
        /// <returns><see cref="DismissRoomResponse"/></returns>
        public DismissRoomResponse DismissRoomSync(DismissRoomRequest req)
        {
            return InternalRequestAsync<DismissRoomResponse>(req, "DismissRoom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏联机对战引擎MGOBE已于6.1正式下架，感谢您的支持
        /// 
        /// 修改房间
        /// </summary>
        /// <param name="req"><see cref="ModifyRoomRequest"/></param>
        /// <returns><see cref="ModifyRoomResponse"/></returns>
        public Task<ModifyRoomResponse> ModifyRoom(ModifyRoomRequest req)
        {
            return InternalRequestAsync<ModifyRoomResponse>(req, "ModifyRoom");
        }

        /// <summary>
        /// 此接口无法使用，游戏联机对战引擎MGOBE已于6.1正式下架，感谢您的支持
        /// 
        /// 修改房间
        /// </summary>
        /// <param name="req"><see cref="ModifyRoomRequest"/></param>
        /// <returns><see cref="ModifyRoomResponse"/></returns>
        public ModifyRoomResponse ModifyRoomSync(ModifyRoomRequest req)
        {
            return InternalRequestAsync<ModifyRoomResponse>(req, "ModifyRoom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口无法使用，游戏联机对战引擎MGOBE已于6.1正式下架，感谢您的支持
        /// 
        /// 踢出房间玩家
        /// </summary>
        /// <param name="req"><see cref="RemoveRoomPlayerRequest"/></param>
        /// <returns><see cref="RemoveRoomPlayerResponse"/></returns>
        public Task<RemoveRoomPlayerResponse> RemoveRoomPlayer(RemoveRoomPlayerRequest req)
        {
            return InternalRequestAsync<RemoveRoomPlayerResponse>(req, "RemoveRoomPlayer");
        }

        /// <summary>
        /// 此接口无法使用，游戏联机对战引擎MGOBE已于6.1正式下架，感谢您的支持
        /// 
        /// 踢出房间玩家
        /// </summary>
        /// <param name="req"><see cref="RemoveRoomPlayerRequest"/></param>
        /// <returns><see cref="RemoveRoomPlayerResponse"/></returns>
        public RemoveRoomPlayerResponse RemoveRoomPlayerSync(RemoveRoomPlayerRequest req)
        {
            return InternalRequestAsync<RemoveRoomPlayerResponse>(req, "RemoveRoomPlayer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
